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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.FirstName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasColumnType(SqlDbType.VarChar.ToString()).HasMaxLength(100);
            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200);

            builder.HasOne(x => x.CreateUser).WithMany().HasForeignKey(x => x.CreatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.UpdateUser).WithMany().HasForeignKey(x => x.UpdatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
           builder.HasOne(x => x.Avatar).WithMany().HasForeignKey(x => x.AvatarId).OnDelete(DeleteBehavior.Cascade);
        }
       
    }
}
