//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class YIELD_RATE_BY_LINE_SCREEN
    {
        public string process { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> hour { get; set; }
        public string line { get; set; }
        public Nullable<int> OK { get; set; }
        public Nullable<int> TOTAL { get; set; }
    }
}