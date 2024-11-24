using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    public class CityConfig: BaseEntityTypeConfiguration<City, Guid>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            RequiredTraceable = true;
            UseForTraceable = true;
            GeneratedValueForKey = true;
            base.Configure(builder);

            builder.HasOne(x => x.Province).WithMany(x => x.Cities).HasForeignKey(x => x.ProvinceId);
            builder.Property(x => x.CityName).IsRequired().HasMaxLength(50);
        }
    }
  
}
