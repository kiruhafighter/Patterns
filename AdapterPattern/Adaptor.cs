using AdapterPattern.DataProcessor;
using AdapterPattern.Network;

namespace AdapterPattern
{
    public class Adaptor : INetworkClient
    {
        private readonly IDataProcessor _processor;

        public Adaptor(IDataProcessor processor)
        {
            _processor = processor;
        }

        public void SendRequest(string ipAddress)
        {
            var apiKey = "def67r63f7827229jiugx77aqh8w8ydwxjic2y82937";
            _processor.SendNetworkRequest(ipAddress, apiKey);
        }
    }
}
