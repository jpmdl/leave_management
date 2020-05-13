using AutoMapper;
using leave_management.Data;
using leave_management.Models;

namespace leave_management.Mappings
{
    // We need the auto mapper to map the view model classes to the database model classes.
    // We could do it by hand but with AutoMapper it's a lot easier.
    public class Maps : Profile
    {
        public Maps()
        {
            // Source, Destination
            CreateMap<LeaveType, DetailsLeaveTypeViewModel>().ReverseMap(); // ReverseMap can map in either direction.
            CreateMap<LeaveType, CreateLeaveTypeViewModel>().ReverseMap(); // ReverseMap can map in either direction.
            CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap(); // ReverseMap can map in either direction.
            CreateMap<LeaveHistory, LeaveHistoryViewModel>().ReverseMap(); // ReverseMap can map in either direction.
            CreateMap<Employee, EmployeeViewModel>().ReverseMap(); // ReverseMap can map in either direction.
        }
    }
}