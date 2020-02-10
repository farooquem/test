using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [DisplayName("Employee Id")]
        public string EmployeeId { get; set; }
        
        public string Name { get; set; }
        [DisplayName("Department")]
        public string DepartmentName { get; set; }
        [DisplayName("Designation")]
        public string Job_Title { get; set; }
        [DisplayName("Contact No.")]
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        [DisplayName("DOB")]
        public string DateOfBirth { get; set; }
        [DisplayName("DOJ")]
        public string DateofJoining { get; set; }
        [DisplayName("DOL")]
        public string DateOfLeaving { get; set; }
        public string Gender { get; set; }
    }
}