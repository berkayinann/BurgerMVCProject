using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menus_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "Extra Products",
                columns: table => new
                {
                    ExtraProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra Products", x => x.ExtraProductId);
                    table.ForeignKey(
                        name: "FK_Extra Products_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Addresses", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cd399d9f-b343-44e7-bc9b-9380a8fb204a", 0, null, "9b30c1c0-c1a9-44ba-9eee-85e9a7616f6c", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", "P@ssword!", "AQAAAAEAACcQAAAAEEDXEY3f6Ms1q3Y9K0ivNJMUc3ssRrKCnjlYV/MhH3BQ4L6cPT3gbO6U3OU/1fYxvQ==", null, false, "", false, "John_Doe" },
                    { "fdcbc75f-fb44-4f71-871d-49c335ded8e7", 0, null, "4d9d148d-0b3c-4633-ae7e-ef39c42802c5", "admin@example.com", true, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Qwe.123", "AQAAAAEAACcQAAAAEDjaGPONJ6OVz9g+30jqCX6eBSoK4ykwBz6BMC6xPqDyaXOk1SieJquDGRiIkx1bUg==", null, false, "", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Extra Products",
                columns: new[] { "ExtraProductId", "Category", "CreatedDate", "ImageSrc", "MenuId", "ModifiedDate", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6775), "DrinkPhotos/1-coca-cola-zero-sugar_30tl.png", null, null, "Coca-Cola Zero Sugar (33 cl)", 30.0, 0 },
                    { 2, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6841), "DrinkPhotos/2-coca-cola-33cl_30tl.png", null, null, "Coca-Cola (33 cl)", 30.0, 0 },
                    { 3, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6852), "DrinkPhotos/3-coca-cola-light_30tl.png", null, null, "Coca-Cola Light (33 cl)", 30.0, 0 },
                    { 4, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6856), "DrinkPhotos/4-fanta-33cl_30tl.png", null, null, "Fanta (33 cl)", 30.0, 0 },
                    { 5, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6861), "DrinkPhotos/5-fuse-tea-33cl_30tl.png", null, null, "Fuse Tea (33 cl)", 30.0, 0 },
                    { 6, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6863), "DrinkPhotos/6-sprite-33cl_30tl.png", null, null, "Sprite (33 cl)", 30.0, 0 },
                    { 7, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6867), "DrinkPhotos/7-ayran-195-ml_20tl.png", null, null, "Ayran (195 ml)", 20.0, 0 },
                    { 8, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6870), "DrinkPhotos/8-ayran-300-ml_25tl.png", null, null, "Ayran (300 ml)", 25.0, 0 },
                    { 9, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6874), "DrinkPhotos/9-su-15.png", null, null, "Water (33 cl)", 15.0, 0 },
                    { 10, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6879), "DrinkPhotos/10-cay_10.png", null, null, "Tea", 10.0, 0 },
                    { 11, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6880), "DrinkPhotos/11-Filtre-Kahve_30.png", null, null, "Filter Coffee", 30.0, 0 },
                    { 12, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6884), "DrinkPhotos/12-Americano_40.png", null, null, "Americano", 40.0, 0 },
                    { 13, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6891), "DrinkPhotos/13-Latte_50.png", null, null, "Latte", 50.0, 0 },
                    { 14, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6893), "DrinkPhotos/14-Findik_Latte_55.png", null, null, "Hazelnut Latte", 55.0, 0 },
                    { 15, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6897), "DrinkPhotos/15-Karamel_Latte_55.png", null, null, "Caramel Latte", 55.0, 0 },
                    { 16, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6899), "DrinkPhotos/16-Chai_Tea _Latte_55.png", null, null, "Chai Tea Latte", 55.0, 0 },
                    { 17, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6902), "DrinkPhotos/17-Cappucino_50.png", null, null, "Cappucino", 50.0, 0 },
                    { 18, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6905), "DrinkPhotos/18-Flat_White_50.png", null, null, "Flat White", 50.0, 0 },
                    { 19, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6908), "DrinkPhotos/19-mocha_50.png", null, null, "Mocha", 50.0, 0 },
                    { 20, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6911), "DrinkPhotos/20-Turk_Kahvesi_45.png", null, null, "Turkish Coffee", 45.0, 0 },
                    { 21, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6914), "DrinkPhotos/21-Sicak_cikolata_45.png", null, null, "Hot Chocolate", 45.0, 0 },
                    { 22, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6917), "DrinkPhotos/22-iced-americano_40.png", null, null, "Iced Americano", 40.0, 0 },
                    { 23, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6919), "DrinkPhotos/23-iced-latte_50.png", null, null, "Iced Latte", 50.0, 0 },
                    { 24, 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6925), "DrinkPhotos/24-iced-mocha_50.png", null, null, "Iced Mocha", 50.0, 0 },
                    { 25, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6928), "BurgerPhotos/1-hamburger_115.png", null, null, "Hamburger", 115.0, 0 },
                    { 26, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6932), "BurgerPhotos/2-cheeseburger_120.png", null, null, "Cheeseburger", 120.0, 0 },
                    { 27, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6935), "BurgerPhotos/3-double_cheeseburger_155.png", null, null, "Double Cheeseburger", 155.0, 0 },
                    { 28, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6939), "BurgerPhotos/4-mega_double_cheeseburger_250.png", null, null, "Mega Double Cheeseburger", 250.0, 0 },
                    { 29, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6942), "BurgerPhotos/5-kofteburger_130.png", null, null, "Meatball Burger", 130.0, 0 },
                    { 30, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6945), "BurgerPhotos/6-double_kofteburger_145.png", null, null, "Double Meatball Burger", 145.0, 0 },
                    { 31, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6949), "BurgerPhotos/7-whopper_170.png", null, null, "Whopper", 170.0, 0 },
                    { 32, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6951), "BurgerPhotos/8-double_whopper_235.png", null, null, "Double Whopper", 235.0, 0 },
                    { 33, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6954), "BurgerPhotos/9-triple_whopper_280.png", null, null, "Triple Whopper", 280.0, 0 },
                    { 34, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6957), "BurgerPhotos/10-tavukburger_100.png", null, null, "Chicken Burger", 100.0, 0 },
                    { 35, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6959), "BurgerPhotos/11-king_chicken_burger_120.png", null, null, "King Chicken Burger", 120.0, 0 },
                    { 36, 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6964), "BurgerPhotos/12-double_king_chicken_150.png", null, null, "Double King Chicken Burger", 150.0, 0 },
                    { 37, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6970), "SnacksPhotos/1-patates_kucuk_35.png", null, null, "French Fries Small", 35.0, 0 },
                    { 38, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6974), "SnacksPhotos/2-patates_orta_40.png", null, null, "French Fries Medium", 40.0, 0 },
                    { 39, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6977), "SnacksPhotos/3-patates_buyuk_45.png", null, null, "French Fries Large", 45.0, 0 },
                    { 40, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6979), "SnacksPhotos/4-sogan-halkasi_8li_35.png", null, null, "Onion Rings (8 pieces)", 35.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Extra Products",
                columns: new[] { "ExtraProductId", "Category", "CreatedDate", "ImageSrc", "MenuId", "ModifiedDate", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 41, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6984), "SnacksPhotos/5-sogan-halkasi_12li_40.png", null, null, "Onion Rings (12 pieces)", 40.0, 0 },
                    { 42, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6986), "SnacksPhotos/6-sogan-halkasi_16li_45.png", null, null, "Onion Rings (16 pieces)", 60.0, 0 },
                    { 43, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6990), "SnacksPhotos/7-chicken-tenders_4lu_40.png", null, null, "Chicken Tenders (4 pieces)", 40.0, 0 },
                    { 44, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6995), "SnacksPhotos/8-chicken-tenders_6li_55.png", null, null, "Chicken Tenders (6 pieces)", 55.0, 0 },
                    { 45, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6997), "SnacksPhotos/9-chicken-tenders_9lu_70.png", null, null, "Chicken Tenders (9 pieces)", 70.0, 0 },
                    { 46, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7001), "SnacksPhotos/10-nuggets_4lu_40.png", null, null, "Nuggets (4 pieces)", 40.0, 0 },
                    { 47, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7003), "SnacksPhotos/11-nuggets_6li_55.png", null, null, "Nuggets (6 pieces)", 55.0, 0 },
                    { 48, 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7008), "SnacksPhotos/12-nuggets_9lu_70.png", null, null, "Nuggets (9 pieces)", 70.0, 0 },
                    { 49, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7013), "SaucesPhotos/1-ketcap_sos_5tl.png", null, null, "Ketchup", 5.0, 0 },
                    { 50, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7016), "SaucesPhotos/2-mayonez_sos_5tl.png", null, null, "Mayonnaise", 5.0, 0 },
                    { 51, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7020), "SaucesPhotos/3-sarimsakli_mayonez_sos_5tl.png", null, null, "Garlic Mayonnaise", 5.0, 0 },
                    { 52, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7023), "SaucesPhotos/4-ranch-sos_5tl.png", null, null, "Ranch Sauce", 5.0, 0 },
                    { 53, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7025), "SaucesPhotos/5-barbeku_sos_5tl.png", null, null, "Barbeque Sauce", 5.0, 0 },
                    { 54, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7027), "SaucesPhotos/6-Aci_sos_5tl.png", null, null, "Hot Sauce", 5.0, 0 },
                    { 55, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7031), "SaucesPhotos/7-aci_hardal_sos_5tl.png", null, null, "Hot Mustard Sauce", 5.0, 0 },
                    { 56, 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7033), "SaucesPhotos/8-buffalo_sos_5tl.png", null, null, "Buffalo Sauce", 5.0, 0 },
                    { 57, 3, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7037), "DessertPhotos/1-cikolatali-cookie_60tl.png", null, null, "Chocolate Cookies", 60.0, 0 },
                    { 58, 3, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7040), "DessertPhotos/2-cikolata-parcacikli-cookie_60tl.png", null, null, "Chocolate Chip Cookies", 60.0, 0 },
                    { 59, 3, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7058), "DessertPhotos/3-elmali-tatli-60tl.png", null, null, "Apple Dessert", 60.0, 0 },
                    { 60, 3, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7062), "DessertPhotos/4-visneli-tatli-60tl.png", null, null, "Cherry Dessert", 60.0, 0 },
                    { 61, 3, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7064), "DessertPhotos/5-sufle-70tl.png", null, null, "Souffle", 70.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "CreatedDate", "Description", "ImageSrc", "ModifiedDate", "Name", "OrderId", "Price", "Quantity", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8553), "Delicacy consisting of hamburger meat, small sesame sandwich bread, pickled cucumber, mustard and ketchup. Enjoy the Hamburger Menu as you wish, with delicious fries and drinks!", "MenuPhotos/1-hamburger-menu_145.png", null, "Hamburger Menu", null, 145.0, 0, 2 },
                    { 2, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8573), "Delicacy consisting of hamburger meat, small sesame sandwich bread, pickled cucumber, cheddar cheese, mustard and ketchup. Enjoy the Cheeseburger Menu as you wish, with delicious fries and drinks!", "MenuPhotos/2-cheeseburger_menu_150.png", null, "Cheeseburger Menu", null, 150.0, 0, 2 },
                    { 3, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8578), "Delicacy consisting of 2 hamburger meat, small sesame sandwich bread, pickled cucumber, 2 pieces of cheddar cheese, mustard and ketchup.", "MenuPhotos/3-double_cheeseburger_menu_185.png", null, "Double Cheeseburger Menu", null, 185.0, 0, 2 },
                    { 4, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8580), "The flavor consists of 2 Whopper meats, large sesame sandwich bread, pickled cucumber, 4 pieces of cheddar cheese, mustard and ketchup. Enjoy the Mega Double Cheeseburger Menu with delicious fries and drink as you wish!", "MenuPhotos/4-mega-double-cheeseburger-menu_280.png", null, "Mega Double Cheeseburger Menu", null, 280.0, 0, 2 },
                    { 5, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8585), "A unique combination of meatball burger meat prepared according to mother's recipe, small sesame sandwich bread, pickled cucumber, ketchup, mayonnaise and lettuce. Enjoy the Meatball Burger Menu as you wish, with delicious fries and drink!", "MenuPhotos/5-kofteburger_menu_160.png", null, "Meatball Burger Menu", null, 160.0, 0, 2 },
                    { 6, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8588), "A unique combination of 2 Meatball burger meats, cheddar cheese, small sesame sandwich bread, pickled cucumber, ketchup, mayonnaise and lettuce, prepared according to mother's recipe. Enjoy the Double Meatball Burger Menu with delicious fries and drink as you wish!", "MenuPhotos/6-double-kofteburger-menu_175.png", null, "Double Meatball Burger Menu", null, 175.0, 0, 2 },
                    { 7, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8590), "A classic consisting of Whopper meat, large sesame sandwich bread, pickled cucumber, ketchup, mayonnaise, chopped lettuce, tomato and onion. Enjoy the Whopper Menu as you wish, with delicious fries and drinks!", "MenuPhotos/7-whopper-menu_200.png", null, "Whopper Menu", null, 200.0, 0, 2 },
                    { 8, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8597), "Perfect for doubling the classic Whopper flavor with two Whopper meats, large sesame buns, pickled cucumber, ketchup, mayonnaise, chopped lettuce, tomato and onion. Enjoy the Double Whopper Menu as you wish, with delicious fries and drinks!", "MenuPhotos/8-double-whopper-menu_265.png", null, "Double Whopper Menu", null, 265.0, 0, 2 },
                    { 9, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8600), "A delicious selection consisting of 3 Whopper meats, large sesame sandwich bread, pickled cucumber, ketchup, mayonnaise, lettuce, tomato and onion. Enjoy the Triple Whopper Menu with delicious fries and drinks as you wish!", "MenuPhotos/9-triple-whopper-menu_310.png", null, "Triple Whopper Menu", null, 310.0, 0, 2 },
                    { 10, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8605), "Enjoy this extremely simple alternative consisting of chicken burger meat, small sesame sandwich bread, mayonnaise and chopped lettuce, along with delicious fries and a drink, as you wish!", "MenuPhotos/10-tavukburger-menu_130.png", null, "Chicken Burger Menu", null, 130.0, 0, 2 },
                    { 11, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8608), "Enjoy this extremely simple alternative consisting of King Chicken meat, sesame sandwich bread, mayonnaise and chopped lettuce, along with delicious fries and a drink, as you wish!", "MenuPhotos/11-king_chicken_burger_menu_150.png", null, "King Chicken Burger Menu", null, 150.0, 0, 2 },
                    { 12, new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8610), "Enjoy the classic flavor alternative consisting of 2 King Chicken meat, sesame sandwich bread, mayonnaise and chopped lettuce, along with delicious fries and a drink, as you wish!", "MenuPhotos/12-double-king-chicken-menu_180.png", null, "Double King Chicken Burger Menu", null, 180.0, 0, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Extra Products_MenuId",
                table: "Extra Products",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderId",
                table: "Menus",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Extra Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
