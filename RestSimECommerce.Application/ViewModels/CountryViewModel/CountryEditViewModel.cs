using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSimECommerce.Application.ViewModels.CountryViewModel
{
    public class CountryEditViewModel
    {
        public string CountryID { get; set; }

        public string CountryName { get; set; }

        public string SelectedCountryIso3 { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public string SelectedRegionCode { get; set; }
        public IEnumerable<SelectListItem> Regions { get; set; }
    }
}
