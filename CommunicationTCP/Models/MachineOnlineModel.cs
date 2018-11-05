using CommunicationTCP.SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTCP.Models
{
    public class MachineOnlineModel
    {
        public Proc_Machines_Result MachineInfor { get; set; }
        public bool isOnline { get; set; } = false;
    }
}
