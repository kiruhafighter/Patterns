namespace ChainOfResponsibility
{
    public class SendARP :IChain
    {
        private IChain? _next;

        public void SendRequest(NetworkModel request)
        {
            Console.WriteLine($"Sending ARP request to {request.IP}");
            if (request.Success)
            {
                Console.WriteLine("Sending ARP is Succesful");
            }
            else if(_next != null)
            {
                Console.WriteLine("Sending ARP failed");
                //request.Success = true;
                _next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("ARP cannot handle it and pass to the next service");
            }
        }

        public void SetNext(IChain nextChain)
        {
            _next = nextChain;
        }
    }
}
