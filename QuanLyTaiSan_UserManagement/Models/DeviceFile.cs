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
    
    public partial class DeviceFile
    {
        public int id { get; set; }
        public Nullable<int> DeviceId { get; set; }
        public string DeviceCode { get; set; }
        public string FileNames { get; set; }
        public string FileSize { get; set; }
        public string FileContent { get; set; }
        public string FileType { get; set; }
        public string FileStatus { get; set; }
        public string FileLocal { get; set; }
        public string IsDelete { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
