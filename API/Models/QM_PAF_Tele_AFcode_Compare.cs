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
    
    public partial class QM_PAF_Tele_AFcode_Compare
    {
        public long table_id { get; set; }
        public string no { get; set; }
        public string line { get; set; }
        public string machine_id { get; set; }
        public string process { get; set; }
        public string port { get; set; }
        public string file_name { get; set; }
        public string module_id { get; set; }
        public Nullable<System.DateTime> test_time { get; set; }
        public string pass_fail { get; set; }
        public string c10Cm_AF_Pos { get; set; }
        public string c50Cm_AF_Pos { get; set; }
        public string c100Cm_AF_Pos { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> modelId { get; set; }
    }
}
