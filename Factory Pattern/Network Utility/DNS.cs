namespace Factory_Pattern.Network_Utility
{
    public class DNS : INetwork
    {
        public void SendRequest(string ip, int timeSent)
        {
            Console.WriteLine("DNS request sent to " + ip + " " + timeSent + " times");
        }
    }
}
