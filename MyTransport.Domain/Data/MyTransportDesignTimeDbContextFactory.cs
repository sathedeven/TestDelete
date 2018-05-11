using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTransport.Domain.Data.Entities
{
    public class MyTransportDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyTransportDbContext> 
    {
        public MyTransportDbContext CreateDbContext(string [] args)
        {
            return new MyTransportDbContext(
                new DbContextOptionsBuilder<MyTransportDbContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mytransport-dev;Integrated Security=True;")
                .Options
            );
        }
    }
}
