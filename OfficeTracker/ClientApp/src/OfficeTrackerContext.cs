using Microsoft.EntityFrameworkCore;
using OfficeTracker.ClientApp.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeTracker.ClientApp.src
{
  public class OfficeTrackerContext : DbContext
  {
    public OfficeTrackerContext(DbContextOptions<OfficeTrackerContext> options) : base(options)
    {

    }

    public DbSet<Office> Offices { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Office>().ToTable("Office");
      modelBuilder.Entity<Manager>().ToTable("Manager");
      modelBuilder.Entity<Employee>().ToTable("Employee");
    }
  }
}
