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
    
    public partial class CM_Log_Machine
    {
        public long id { get; set; }
        public int machineId { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public Nullable<System.DateTime> time_stop { get; set; }
        public string status { get; set; }
        public string detail { get; set; }
        public int modelId { get; set; }
    }
}
