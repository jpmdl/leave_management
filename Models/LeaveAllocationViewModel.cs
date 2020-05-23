using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace leave_management.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }

        [Required]
        public int NumberOfDays { get; set; }

        public DateTime DateCreated { get; set; }

        // We need to change the Data classes dependencies to View Model dependencies to create the necessary level of abstraction.
        public EmployeeViewModel Employee { get; set; }

        public string EmployeeId { get; set; }

        // Details will have everything we need
        public LeaveTypeViewModel LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        // For the user to select the user and the leave type from a list.
        public IEnumerable<SelectListItem> Employees { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
}