using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestSimECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSimECommerce.Infrastructure.EF
{
    public class RestSimECommerceContext: IdentityDbContext
    {
        public RestSimECommerceContext(DbContextOptions<RestSimECommerceContext> options)
            :base(options)
        { }

        //DbSet creation
       // public virtual DbSet<RestSimEComWebUser> RestSimEComWebUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


        }
    }
}
