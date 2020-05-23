using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using leave_management.Models;

namespace leave_management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Property inside AppDbContext to instruct the DB Context to create a table of type `Employee` named `Employees`. 
        // This table should be part of the `DbSet`.
        // $ dotnet ef migrations add "Description"
        // $ dotnet ef database update
        public DbSet<Employee> Employees { get; set; }

        public DbSet<LeaveHistory> LeaveHistories { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<leave_management.Models.LeaveTypeViewModel> DetailsLeaveTypeViewModel { get; set; }
    }
}
