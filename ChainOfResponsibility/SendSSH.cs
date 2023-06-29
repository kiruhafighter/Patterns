namespace ChainOfResponsibility
{
    public class SendSSH : IChain
    {
        private IChain? _next;

        public void SendRequest(NetworkModel request)
        {
            Console.WriteLine($"Sending SSH request to {request.IP}");
            if (request.Success)
            {
                Console.WriteLine("Sending SSH is succesful");
            }
            else if(_next != null)
            {
                Console.WriteLine("Sending SSH failed");
                //request.Success = true;
                _next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("SSH cannot handle it and pass to the next service");
            }
        }

        public void SetNext(IChain nextChain)
        {
            _next = nextChain;
        }
    }
}
