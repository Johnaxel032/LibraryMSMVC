//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookFineTable
    {
        public int BookFineID { get; set; }
        public int EmployeeID { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }
        public System.DateTime FineDate { get; set; }
        public double FineAmount { get; set; }
        public Nullable<double> ReceiveAmount { get; set; }
        public int NoOfDays { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual EmployeeTable EmployeeTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
