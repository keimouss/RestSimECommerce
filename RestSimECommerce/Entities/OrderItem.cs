﻿using System;
using System.Collections.Generic;

namespace RestSimECommerce.Entities
{
    public  class OrderItem
    {
        public int Id { get; set; }
        public Guid OrderItemGuid { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPriceInclTax { get; set; }
        public string AttributeDescription { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}