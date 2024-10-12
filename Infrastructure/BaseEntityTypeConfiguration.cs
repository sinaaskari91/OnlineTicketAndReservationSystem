﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class BaseEntityTypeConfiguration<T,KeyTypeId>:IEntityTypeConfiguration<T>where T : BaseEntity<KeyTypeId>where KeyTypeId : struct
    {
        protected bool GeneratedValueForKey {  get; set; }=true;
        protected bool UseForTraceable { get; set; }=false;
        protected bool RequiredTraceable {  get; set; }=false;
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            if (GeneratedValueForKey )
            {
                builder.Property(x=>x.Id).ValueGeneratedOnAdd();

            }
            if (UseForTraceable==false)
            {
                builder.Ignore(x=>x.CreatedDateTime);
                builder.Ignore(x=>x.UpdatedDateTime);
                builder.Ignore(x=>x.CreatedUserId);
                builder.Ignore(x=>x.UpdatedUserId);
                builder.Ignore(x=>x.CreatedUser);
                builder.Ignore(x=>x.UpdatedUser);
            }
            else
            {
                builder.Property(x => x.CreatedDateTime).IsRequired(RequiredTraceable);
                builder.Property(x => x.UpdatedDateTime).IsRequired(RequiredTraceable);

                builder.HasOne(x => x.CreatedUser).WithMany().HasForeignKey(x => x.CreatedUserId).IsRequired(RequiredTraceable).OnDelete(DeleteBehavior.NoAction);
                builder.HasOne(x => x.UpdatedUser).WithMany().HasForeignKey(x => x.UpdatedUserId).IsRequired(RequiredTraceable).OnDelete(DeleteBehavior.NoAction);

            }
        }
    }
}
