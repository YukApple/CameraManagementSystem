using CommunicationTCP.Models;
using CommunicationTCP.SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTCP
{
    public interface ITCPCom
    {
        Task<List<MachineOnlineModel>> Recv_GetMachineOnline(string jsondata);
        Task<string> Send_GetMachineOnline();
    }
}
