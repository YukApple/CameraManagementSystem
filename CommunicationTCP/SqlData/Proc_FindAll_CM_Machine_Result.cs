//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunicationTCP.SqlData
{
    using System;
    
    public partial class Proc_FindAll_CM_Machine_Result
    {
        public int id { get; set; }
        public string ip { get; set; }
        public string name { get; set; }
        public int lineId { get; set; }
        public Nullable<int> socketId { get; set; }
        public Nullable<int> SOCKETQTY { get; set; }
        public string MACHINE_SPEC { get; set; }
        public string SCARA_YN { get; set; }
        public Nullable<int> portId { get; set; }
        public Nullable<int> processId { get; set; }
        public string status { get; set; }
        public Nullable<bool> ip_equiment { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public string log_path { get; set; }
        public string log_path2 { get; set; }
        public string serial_machine { get; set; }
        public string pathdll { get; set; }
        public string pathexe { get; set; }
        public string pathremote { get; set; }
        public string softwarename { get; set; }
    }
}
