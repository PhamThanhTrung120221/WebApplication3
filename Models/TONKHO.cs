//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TONKHO
    {
        public int ngaykk { get; set; }
        public string mathuoc { get; set; }
        public int sldau { get; set; }
        public int slnhap { get; set; }
        public int slxuat { get; set; }
        public int slcovande { get; set; }
        public int slcuoi { get; set; }
    
        public virtual THUOC THUOC { get; set; }
    }
}
