namespace ChainOfResponsibility
{
    public class NetworkModel
    {
        public string  IP { get; set; }
        public bool Success { get; set; }
        public NetworkModel(string IP, bool success)
        {
            this.IP = IP;
            this.Success = success;
        }
    }
}
