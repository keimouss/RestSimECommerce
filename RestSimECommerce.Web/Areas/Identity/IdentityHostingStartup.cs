using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using RestSimECommerce.Entities;
//using RestSimECommerce.Infrastructure.EF;
using RestSimECommerce.Web.Areas.Identity.Data;
using RestSimECommerce.Web.Data;
//using RestSimECommerce.Web.Models;

[assembly: HostingStartup(typeof(RestSimECommerce.Web.Areas.Identity.IdentityHostingStartup))]
namespace RestSimECommerce.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RestSimECommerceContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RestSimEComConnection")));

                services.AddDefaultIdentity<RestSimEComWebUser>()
                    .AddEntityFrameworkStores<RestSimECommerceContext>();
            });
        }
    }
}