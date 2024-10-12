using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    
    public class BaseConfig<T, KeyTypeId> : IEntityTypeConfiguration<T> where T : BaseEntity<KeyTypeId> where KeyTypeId : struct
    {
        protected bool UseIdentity {  get; set; }=true;
        protected bool Required { get; set; } = false;
        protected   bool UseTraceable { get; set; }=true;
        public void Configure(EntityTypeBuilder<T> builder)
        {
            if (UseIdentity)
            {
                builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            }

           
            if (UseTraceable)
            {

                builder.Property(x => x.CreatedUserId).IsRequired(Required);
                builder.Property(x => x.UpdatedUserId).IsRequired(Required);
                builder.Property(x => x.UpdatedUser).IsRequired(Required);
                builder.Property(x => x.CreatedUser).IsRequired(Required);
                builder.HasOne(u => u.CreatedUser).WithMany().HasForeignKey(u => u.CreatedUserId);
                builder.HasOne(u => u.UpdatedUser).WithMany().HasForeignKey(u => u.UpdatedUserId);
            }
            else
            {
                builder.Ignore(x=>x.CreatedUserId);
                builder.Ignore(x=>x.CreatedUser);
                builder.Ignore(x=>x.UpdatedUserId);
                builder.Ignore(x=>x.UpdatedUser);

            }

           

        }
    }
}
