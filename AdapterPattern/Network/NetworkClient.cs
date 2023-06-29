﻿namespace AdapterPattern.Network
{
    public class NetworkClient : INetworkClient
    {
        public void SendRequest(string ipAddress)
        {
            Console.WriteLine("Network client request sent to IP:" + ipAddress);
        }
    }
}
