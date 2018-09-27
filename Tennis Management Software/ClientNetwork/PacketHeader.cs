using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software.ClientNetwork
{
    public class PacketHeader
    {
        public Packet.PacketID PacketID;
        public int PacketLength;

        public PacketHeader(Packet.PacketID packetID, int packetLength)
        {
            this.PacketID = packetID;
            this.PacketLength = packetLength;
        }

        public PacketHeader()
        {
            this.PacketID = 0;
            this.PacketLength = 0;
        }
    }
}
