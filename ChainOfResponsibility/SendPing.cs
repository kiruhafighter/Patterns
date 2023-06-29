namespace ChainOfResponsibility
{
    public class SendPing : IChain
    {
        private IChain? _next;

        public void SendRequest(NetworkModel request)
        {
            Console.WriteLine($"Sending Ping request to {request.IP}");
            if (request.Success)
            {
                Console.WriteLine("Sending Ping is succesful");
            }
            else if(_next != null)
            {
                Console.WriteLine("Sending Ping failed");
                //request.Success = true;
                _next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Ping cannot handle it and pass to the next service");
            }
        }

        public void SetNext(IChain nextChain)
        {
            _next = nextChain;
        }
    }
}
