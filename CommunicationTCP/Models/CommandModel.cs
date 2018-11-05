using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTCP.Models
{
    public class CommandModel
    {
        public string Command { get; set; }
        public string Model { get; set; }
        public string Data { get; set; }
        public int DataLength { get; set; }
    }
}
