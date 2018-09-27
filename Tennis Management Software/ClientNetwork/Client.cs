using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Tennis_Management_Software.ClientNetwork
{
    public class Client
    {
        public Socket ClientSocket { get; private set; }
        public readonly IPAddress IP = new IPAddress(Encoding.BigEndianUnicode.GetBytes("127.0.0,1"));
        public readonly int Port = 356;

        public event EventHandler<SocketException> ConnectionToServerFailed;
        public event EventHandler ConnectionToServerSucceded;
        public event EventHandler<DataReceivedEventArgs> DataReceived;
        public event EventHandler DataSend;
        public event EventHandler<SocketException> SendFailed;
        public event EventHandler<SocketException> ReceiveFailed;


        private Packet packet;
        private byte[] packetHeader;

        public Client()
        {
            packet = new Packet();
            packetHeader = new byte[8];
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Connect()
        {
            try
            {
                ClientSocket.Connect(IP, Port);
                OnConnectionToServerSucceded();
                ClientSocket.BeginReceive(packetHeader, 0, packetHeader.Length, SocketFlags.None, new AsyncCallback(ReceivePacketHeaderCallback), ClientSocket);
                return true;
            }
            catch(SocketException ex)
            {
                OnConnectionToServerFailed(ex);
                return false;
            }
        }

        public void SendDataAsync(byte[] data)
        {
            try
            {
                ClientSocket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendDataCallback), ClientSocket);
            }
            catch(SocketException ex)
            {
                OnSendFailed(ex);
            }
        }

        private void SendDataCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);

            OnDataSend();
        }

        private void ReceivePacketHeaderCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndReceive(ar);

            PacketHeader header = new PacketHeader((Packet.PacketID)Convert.ToInt32(packetHeader.Take(2)), Convert.ToInt32(packetHeader.Skip(2)));
            packet.Header = header;

            //There is additional data.
            if(header.PacketLength > 0)
                socket.BeginReceive(packet.Data, 0, packet.Header.PacketLength, SocketFlags.None, new AsyncCallback(ReceivePacketDataCallback), ClientSocket);
            else
                socket.BeginReceive(packetHeader, 0, packetHeader.Length, SocketFlags.None, new AsyncCallback(ReceivePacketHeaderCallback), ClientSocket);
        }

        private void ReceivePacketDataCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndReceive(ar);

            OnDataReceived(new DataReceivedEventArgs(packet));
            ClientSocket.BeginReceive(packetHeader, 0, packetHeader.Length, SocketFlags.None, new AsyncCallback(ReceivePacketHeaderCallback), socket);
        }

        private void OnConnectionToServerFailed(SocketException e)
        {
            if (ConnectionToServerFailed != null)
                ConnectionToServerFailed(this, e);
        }

        private void OnConnectionToServerSucceded()
        {
            if (ConnectionToServerSucceded != null)
                ConnectionToServerSucceded(this, new EventArgs());
        }

        private void OnDataReceived(DataReceivedEventArgs e)
        {
            if (DataReceived != null)
                DataReceived(this, e);
        }

        private void OnDataSend()
        {
            if (DataSend != null)
                DataSend(this, new EventArgs());
        }

        private void OnSendFailed(SocketException e)
        {
            if (SendFailed != null)
                SendFailed(this, e);
        }

        public static bool IsConnectedToNetwork()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }

        public static byte[] CreateDataForSending(string data, Packet.PacketID id)
        {
            List<byte> dataToSend = new List<byte>();
            dataToSend.AddRange(BitConverter.GetBytes((int)id));
            dataToSend.AddRange(BitConverter.GetBytes(Encoding.ASCII.GetByteCount(data)));
            dataToSend.AddRange(Encoding.ASCII.GetBytes(data));

            return dataToSend.ToArray();
        }
    }
}
