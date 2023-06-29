namespace FacadePattern
{
    public class Packet
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string IP { get; set; }

        public Packet(string ip)
        {
            IP = ip;
        }

        public void PacketBuilt()
        {
            Console.WriteLine("Packet Built");
        }
    }
}
