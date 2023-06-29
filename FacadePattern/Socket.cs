namespace FacadePattern
{
    public class Socket
    {
        public int IP { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }

        public Socket(string protocol)
        { 
            Protocol = protocol;
        }

        public void BuildSocket()
        {
            Console.WriteLine("Build Socket"); 
        }
    }
}
