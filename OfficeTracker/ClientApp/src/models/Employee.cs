using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTracker.ClientApp.src.models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Office Office { get; set; }
    }
}
