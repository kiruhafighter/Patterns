namespace Factory_Pattern.Network_Utility
{
    public class Ping : INetwork
    {
        public void SendRequest(string ip, int timeSent)
        {
            Console.WriteLine("Ping request sent to " + ip + " " + timeSent + " times");
        }
    }
}
