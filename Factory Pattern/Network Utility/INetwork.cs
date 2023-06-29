namespace Factory_Pattern.Network_Utility
{
    public interface INetwork
    {
        void SendRequest(string ip, int timeSent);
    }
}
