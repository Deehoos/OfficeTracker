using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTracker.ClientApp.src.models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }
        public Manager Manager { get; set; }
    }
}
