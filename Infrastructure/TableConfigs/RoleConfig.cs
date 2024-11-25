using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable(nameof(Role));
            //builder.Property(x => x.CreatedDateTime).IsRequired().HasDefaultValue(DateTime.Now);
            //builder.Property(x => x.UpdatedDateTime).IsRequired().HasDefaultValue(DateTime.Now);

            //builder.HasOne(x => x.CreatedUser).WithMany().HasForeignKey(x => x.CreatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(x => x.UpdatedUser).WithMany().HasForeignKey(x => x.UpdatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
