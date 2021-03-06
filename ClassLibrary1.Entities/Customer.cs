﻿using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public CustomerSetting CustomerSetting { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
