using OfficeTracker.ClientApp.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTracker.ClientApp.src
{
  public class DbInitializer
  {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

      Manager manager1 = new Manager { Id=1, Name="Jerry", ManagedOffice=};
      Office office1 = new Office { Id = 0, Location = "Plano", Employees = { } };
      Employee employee1 = new Employee { Id=0, Name="Dylan", Office=office1, Role=}

            // Look for any Employees.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var Employees = new Employee[]
            {
                new Employee{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                
            };
            foreach (Employee s in Employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Manager{ManagerID=1050,Title="Chemistry",Credits=3},
                
            };
            foreach (Manager c in Managers)
            {
                context.Managers.Add(c);
            }
            context.SaveChanges();

            var Offices = new Office[]
            {
                new List<Employee> {new Employee { Id=1, Name="Bob", Office=} }

                new Office{Id=1, Location="Plano", },
            };
            foreach (Office e in Offices)
            {
                context.Offices.Add(e);
            }
            context.SaveChanges();
        }
    }
}
