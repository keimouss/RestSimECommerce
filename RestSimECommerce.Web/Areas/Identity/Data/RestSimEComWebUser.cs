using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RestSimECommerce.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the RestSimEComWebUser class
    public class RestSimEComWebUser : IdentityUser
    {
       [PersonalData]
        public string Name { get; set; }
        
       [PersonalData]
        public DateTime DOB { get; set; }

    }

    //[AttributeUsage(AttributeTargets.Property)]
    //public class PersonalDataAttribute:Attribute
    //{ }
}
