namespace AdapterPattern.Network
{
    public interface INetworkClient
    {
        void SendRequest(string ipAddress);
    }
}
