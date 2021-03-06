//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTaiSan_UserManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RepairDetail
    {
        public int Id { get; set; }
        public Nullable<int> DeviceId { get; set; }
        public Nullable<System.DateTime> DateOfRepair { get; set; }
        public Nullable<System.DateTime> NextDateOfRepair { get; set; }
        public Nullable<int> TimeOrder { get; set; }
        public Nullable<int> TypeOfRepair { get; set; }
        public string AddressOfRepair { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Device Device { get; set; }
        public virtual RepairType RepairType { get; set; }
        public virtual User User { get; set; }
    }
}
