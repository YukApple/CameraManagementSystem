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
    
    public partial class QM_PAF_Wide_Panpos
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
        public string actuator_flag { get; set; }
        public string cF2_4_100Cm_Real_AF_Pos { get; set; }
        public string cF1_5_100Cm_Real_AF_Pos { get; set; }
        public string cF2_4_100Cm_PAF_Best_Pos { get; set; }
        public string cF1_5_100Cm_PAF_Best_Pos { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> modelId { get; set; }
    }
}
