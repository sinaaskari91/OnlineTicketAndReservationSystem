using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TableConfigs
{
    public class TicketConfig:IEntityTypeConfiguration<Ticket> 
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable(nameof(Ticket));
            builder.Property(x => x.CreatedDateTime).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedDateTime).IsRequired().HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.CreatedUser).WithMany().HasForeignKey(x => x.CreatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.UpdatedUser).WithMany().HasForeignKey(x => x.UpdatedUserId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
        }

    }
}
