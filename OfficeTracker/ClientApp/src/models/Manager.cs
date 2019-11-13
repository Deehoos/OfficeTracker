using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTracker.ClientApp.src.models
{
    public class Manager
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Office ManagedOffice { get; set; }
    }
}
