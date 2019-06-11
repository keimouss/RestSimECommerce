using System;
using System.Collections.Generic;
using System.Text;

namespace RestSimECommerce.Entities
{
    public abstract class BaseEntity
    {
        int id { get; set; }
        public int Id => this.id;
    }
}
