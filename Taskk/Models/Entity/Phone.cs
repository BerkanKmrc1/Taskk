//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taskk.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phone
    {
        public int ID { get; set; }
        public Nullable<int> Personal { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Personal Personal1 { get; set; }
    }
}
