using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    public class CategoryConfig : BaseEntityTypeConfiguration<Category, Guid>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));
            RequiredTraceable = false;
            UseForTraceable = false;
            GeneratedValueForKey = false;
            base.Configure(builder);

            builder.Property(x => x.CategoryName).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(50).IsRequired();

            
            builder.Property(x => x.CategoryDescription).IsRequired(false).HasMaxLength(500);
        }
    }
}
