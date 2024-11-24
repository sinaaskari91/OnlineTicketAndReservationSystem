using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Infrastructure.TableConfigs
{
    public class ProvinceConfig:BaseEntityTypeConfiguration<Province,Guid>
    {
        public override void Configure(EntityTypeBuilder<Province> builder)
        {
            RequiredTraceable = true;
            UseForTraceable = true;
            GeneratedValueForKey = true;
            base.Configure(builder);

            builder.Property(x => x.ProvinceName).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.ProvincePicture).WithMany().HasForeignKey(x => x.ProvincePictureId).OnDelete(DeleteBehavior.Cascade);



        }
    }
}
