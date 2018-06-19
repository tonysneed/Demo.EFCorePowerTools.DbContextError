using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class CustomerSetting
    {
        public string CustomerId { get; set; }
        public string Setting { get; set; }

        public Customer Customer { get; set; }
    }
}
