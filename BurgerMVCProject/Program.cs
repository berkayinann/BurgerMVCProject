using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.BLL.Services.Concrete;
using BurgerMVCProject.Domain.Context;
using BurgerMVCProject.Domain.Entities;
using DAL.Repositories.Abstract;
using DAL.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddTransient<IExtraProductService, ExtraProductService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IOrderService, OrderService>();

builder.Services.AddTransient<IExtraProductRepository, ExtraProductRepository>();
builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<OrderRepository, OrderRepository>();

builder.Services.AddScoped<UserManager<AppUser>>();

builder.Services.ConfigureApplicationCookie(optsions =>
{
    optsions.LoginPath = "/Account/Login";
    optsions.ExpireTimeSpan = TimeSpan.FromSeconds(60);
});
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = false;
    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
