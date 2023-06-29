using Factory_Pattern.Network_Utility;

namespace Factory_Pattern.NetworkFactory
{
    public class NetworkFactory
    {
        public INetwork? GetNetwork(string type)
        {
            INetwork obj = null;
            if (type.ToLower().Equals("ping"))
            {
                obj = new Ping();
            }
            else if (type.ToLower().Equals("dns"))
            {
                obj = new DNS();
            }
            else if (type.ToLower().Equals("arp"))
            {
                obj = new ARP();
            }
            else
            {
                Console.WriteLine("Type not found");
            }

            return obj;
        }
    }
}
