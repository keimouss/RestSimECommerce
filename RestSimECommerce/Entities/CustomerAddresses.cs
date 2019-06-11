﻿using System;
using System.Collections.Generic;

namespace RestSimECommerce.Entities
{
    public class CustomerAddresses
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
