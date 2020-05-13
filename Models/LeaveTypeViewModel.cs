using System;
using System.ComponentModel.DataAnnotations;

namespace leave_management.Models
{
    // Another level of abstraction for LeaveType. Not the case  but, maybe, we could have some fields hidden in the front. 
    // Or mmaybe we could add some virtual property not present in the database.
    // Enforce prechecks on our view, like required fields and some data validation.
    public class DetailsLeaveTypeViewModel  // To View
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeViewModel   // To Create
    {
        [Required]
        public string Name { get; set; }
    }
}