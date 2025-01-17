﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeeTarcking.Data.DbModels
{
    public class EmployeeLeaveRequest:BaseEntity
    {
        //TODO:Talepte bulunan kullanıcı bilgileri
        public string RequestingEmployeeId { get; set; }
        [ForeignKey("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }
        //TODO:Onaylayan kullanıcı bilgileri
        public string ApprovedEmployeeId { get; set; }
        [ForeignKey("ApprovedEmployeeId")]
        public Employee ApprovedEmployee { get; set; }

        public int EmployeeLeaveTypeId { get; set; }
        [ForeignKey("EmployeeLeaveTypeId")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }



    }
}
