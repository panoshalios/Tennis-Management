using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software.ClientNetwork
{
    public class Packet
    {
        public enum PacketID
        {
            Login,
            LoginSuccessful,
            LoginFailed,
            Save
        }
        
        private PacketHeader header;
        public PacketHeader Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
                Data = new byte[header.PacketLength];
            }
        }

        public byte[] Data;

        public string GetData()
        {
            if (Data != null)
                return Encoding.ASCII.GetString(Data);
            else
                return string.Empty;
        }
    }
}
