﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            if ( args.Length < 4 )
            {
                Console.WriteLine("사용법 : {0} <Bind IP> <Bind Port> <Server IP> <Message>", Process.GetCurrentProcess().ProcessName);
                return;
            }
            string bindIp = args[0];
            int bindPort = Convert.ToInt32(args[1]);
            string serverIp = args[2];
            const int serverPort = 5425;
            string message = args[3];

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                Console.WriteLine($"클라이언트 : {clientAddress.ToString()}, 서버 : {serverAddress.ToString()}");

                TcpClient client = new TcpClient(clientAddress);

                client.Connect(serverAddress);

                byte[] data = System.Text.Encoding.Default.GetBytes(message);

                NetworkStream stream = client.GetStream();

                stream.Write(data, 0 , data.Length);

                Console.WriteLine($"송신 : {message}");

                data = new byte[256];

                string responseData = "";

                int bytes = stream.Read(data, 0 , data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);
                Console.WriteLine($"수신 : {responseData}");

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("클라이언트 종료");
        }
    }
}
