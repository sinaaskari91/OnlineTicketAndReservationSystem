using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class OnlineTicketReservationDbContext :IdentityDbContext<User,Role,Guid>
    {
        public OnlineTicketReservationDbContext() {}
        public OnlineTicketReservationDbContext(DbContextOptions<OnlineTicketReservationDbContext> dbContext) : base(dbContext){}

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OnlineTicket;TrustServerCertificate=True;Integrated Security=SSPI"); 
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        
    }

    public class IdentityDbContext<T>
    {
    }
}
