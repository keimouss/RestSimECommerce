﻿using System;
using System.Collections.Generic;

namespace RestSimECommerce.Entities
{
    public class StateProvince
    {
        public StateProvince()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
