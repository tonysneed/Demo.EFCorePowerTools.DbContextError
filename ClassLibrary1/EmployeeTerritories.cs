using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class EmployeeTerritories
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public Employee Employee { get; set; }
        public Territory Territory { get; set; }
    }
}
