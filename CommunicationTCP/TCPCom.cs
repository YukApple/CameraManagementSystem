using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationTCP.Models;
using CommunicationTCP.SqlData;
using Newtonsoft.Json;

namespace CommunicationTCP
{
    public class TCPCom : ITCPCom
    {
        public async Task<string> Send_GetMachineOnline()
        {
            return await Task.Factory.StartNew(() =>
            {
                CommandModel cmd = new CommandModel();
                using (SCMSEntities db = new SCMSEntities())
                {
                    List<Proc_Machines_Result> machines = db.Proc_Machines().ToList();
                    cmd.Command = CommandMethod.GET.ToString();
                    cmd.Model = ModelMethod.MachineOnlineModel.ToString();
                    cmd.Data = JsonConvert.SerializeObject(machines);
                    cmd.DataLength = machines.Count;
                    return JsonConvert.SerializeObject(cmd);
                }
            });
            
        }

        public async Task<List<MachineOnlineModel>> Recv_GetMachineOnline(string jsondata)
        {
            await Task.Delay(200);
            return new List<MachineOnlineModel>();
        }
    }
}
