//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagement.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.InOutDetails = new HashSet<InOutDetail>();
            this.LeaveDetails = new HashSet<LeaveDetail>();
            this.Salaries = new HashSet<Salary>();
            this.SalarySlips = new HashSet<SalarySlip>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public string Job_Title { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.DateTime DateofJoining { get; set; }
        public Nullable<System.DateTime> DateOfLeaving { get; set; }
        public string Gender { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<InOutDetail> InOutDetails { get; set; }
        public virtual ICollection<LeaveDetail> LeaveDetails { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<SalarySlip> SalarySlips { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}