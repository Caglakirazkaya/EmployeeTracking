using AutoMapper;
using EmployeeTarcking.Data.DbModels;
using EmployeeTracking.Common.ViewModel;

namespace EmployeeTracking.Common.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<EmployeeLeaveType, EmployeeLeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<EmployeeLeaveAllocation, EmployeeLeaveAllocationVM>().ReverseMap();
            CreateMap<EmployeeLeaveRequest, EmployeeLeaveRequestVM>().ReverseMap();
        }
        
    }
}
