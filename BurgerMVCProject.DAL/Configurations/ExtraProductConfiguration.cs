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
    public class ExtraProductConfiguration : IEntityTypeConfiguration<ExtraProduct>
    {
        public void Configure(EntityTypeBuilder<ExtraProduct> builder)
        {
            throw new NotImplementedException();
        }
    }
}
