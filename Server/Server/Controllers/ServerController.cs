using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server
{
    class ServerController
    {

        bool IsStarted =false;
        TcpListener server;
       // string messageToServer;
        NetworkStream myns;
        TcpClient Client;


        public void Start( int port)
        {
            //Start Server Listener
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            while (IsStarted == true)
            {
                Client = server.AcceptTcpClient();
                myns = Client.GetStream();

                byte[] msg = new byte[100];

                msg = Encoding.Default.GetBytes("Accepting");
               
            }
            //server.Stop();

        }
        public void Close(int port)
        {
            IsStarted = false;
            Client.Close();
        }

        public int UserConnectsToClass(IPAddress serverIP, int port)
        {


            //acede aos dados do utilizador
            return 1;
        }

        public int sendMessage(string ip, Int32 port, string message)
        {
            //assuming client exists

            try
            {

                StreamWriter writer = new StreamWriter(Client.GetStream());
                writer.AutoFlush = true; //Either this, or you Flush manually every time you send something.

                writer.WriteLine("My Message");


            }
            catch (Exception ex)
            {
                return 0;
            }

            return 1;
            
       

        }


        public async Task userConnectionAsync(string ip, int port)
        {

            string host = ip;
            int porta = port;
            int timeout = 5000;

            using var client = new TcpClient();

            await client.ConnectAsync(host, porta);

            using var netstream = client.GetStream();
            using var writer = new StreamWriter(netstream);
            using var reader = new StreamReader(netstream);

            writer.AutoFlush = true;
            netstream.ReadTimeout = timeout;

            var message = "Novo Utilizador Connectado";

            await writer.WriteLineAsync(message);

            string response = await reader.ReadToEndAsync();
            
            Console.WriteLine($"Server: {response}");
        }


    }
}
