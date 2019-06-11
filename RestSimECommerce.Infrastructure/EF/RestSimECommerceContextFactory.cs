
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSimECommerce.Infrastructure.EF
{
    public class RestSimECommerceContextFactory : IDesignTimeDbContextFactory<RestSimECommerceContext>
    {
        public RestSimECommerceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RestSimECommerceContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=RestSimECom;Trusted_Connection=True;");
            return new RestSimECommerceContext(optionsBuilder.Options);
        }
    }
}
