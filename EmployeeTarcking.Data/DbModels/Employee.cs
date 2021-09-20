using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.DbModels
{
    public class Employee:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxID { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
