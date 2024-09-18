using Microsoft.EntityFrameworkCore;
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
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(nameof(Role));
            builder.HasOne(u => u.CreatedUser).WithMany(u=>u.Roles).HasForeignKey(u => u.CreatedUserId);
        }
    }
}
