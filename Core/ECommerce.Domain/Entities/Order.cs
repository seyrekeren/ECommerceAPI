﻿using ECommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; } //order ilişki n => n

        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }

    }
}
