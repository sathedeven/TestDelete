using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTransport.Domain.Data.Entities;
using MyTransport.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTransport.Domain.Data
{
    public class MyTransportDbContext : IdentityDbContext<AppUser>
    {
        public MyTransportDbContext(DbContextOptions<MyTransportDbContext> options) : base(options) { }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
