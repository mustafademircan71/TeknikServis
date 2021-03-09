using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.DataAccess.Concrete.EntityFramework.Contexts
{
    public class TeknikServisDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NKKGRR6;database=TeknikServisDb;trusted_connection=true;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Fault> Faults { get; set; }
        public DbSet<DeviceStatus> DeviceStatuses { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
    }
}
