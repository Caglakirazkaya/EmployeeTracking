using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.DbModels
{
    public class EmployeeLeaveType: BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
