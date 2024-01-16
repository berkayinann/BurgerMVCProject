using BurgerMVCProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menus");
            builder.HasKey(x => x.MenuId);

            builder.HasData(
                    new Menu 
                    { 
                        MenuId = 1, 
                        Name = ".", 
                        Price = 100.00, 
                        ImageSrc = "." 
                    },
                    new Menu 
                    { 
                        MenuId = 2, 
                        Name = ".", 
                        Price = 85.00, 
                        ImageSrc = "." 
                    },
                    new Menu 
                    { 
                        MenuId = 3, 
                        Name = ".", 
                        Price = 30, 
                        ImageSrc = "." 
                    },
                    new Menu
                    {
                        MenuId=4,
                        Name="t",
                    }
                );
        }
    }
}
