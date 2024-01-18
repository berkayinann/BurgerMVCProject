using BurgerMVCProject.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasIndex(e => e.Email).IsUnique();
            var adminUserId = Guid.NewGuid().ToString();
            var userUserId = Guid.NewGuid().ToString();
            var adminRoleId = Guid.NewGuid().ToString();
            var userRoleId = Guid.NewGuid().ToString();
            builder.HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
            builder.HasData(new IdentityUserRole<string>
            {
                UserId = adminUserId,
                RoleId = adminRoleId
            },
            new IdentityUserRole<string>
            {
                UserId = userUserId,
                RoleId = userRoleId
            }
                            );

            var hasher = new PasswordHasher<AppUser>();

            builder.HasData(
                new AppUser
                {
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Qwe.123"),
                    FirstName = "Admin",
                    LastName = "Admin",
                    SecurityStamp = string.Empty
                }, 
                new AppUser
                {
                    UserName = "John_Doe",
                    NormalizedUserName = "JOHN_DOE",
                    Email = "john.doe@example.com",
                    NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "P@ssword!"),
                    FirstName = "John",
                    LastName = "Doe",
                    SecurityStamp = string.Empty
                });

        }
    }
}
