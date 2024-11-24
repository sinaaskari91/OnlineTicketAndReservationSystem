using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Infrastructure.TableConfigs
{
    public class BlobConfig : IEntityTypeConfiguration<Blob>
    {

        public void Configure(EntityTypeBuilder<Blob> builder)
        {
            builder.ToTable(nameof(Blob));
            builder.HasKey(x => x.Id);


            builder.Property(x => x.CreatedDateTime).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedDateTime).IsRequired().HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.CreatedUser).WithMany().HasForeignKey(x => x.CreatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.UpdatedUser).WithMany().HasForeignKey(x => x.UpdatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.MimeType).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(300);
            builder.Property(x => x.FileAddress).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(1000);
        }

    }

}

