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
    
    public partial class InOutDetail
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime OfficeDate { get; set; }
        public Nullable<System.TimeSpan> InTIme { get; set; }
        public Nullable<System.TimeSpan> OutTime { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}