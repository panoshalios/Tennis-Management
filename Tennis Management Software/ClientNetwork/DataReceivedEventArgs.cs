using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software.ClientNetwork
{
    public class DataReceivedEventArgs : EventArgs
    {
        public Packet Packet { get; private set; }

        public DataReceivedEventArgs(Packet packet)
        {
            this.Packet = packet;
        }
    }
}
