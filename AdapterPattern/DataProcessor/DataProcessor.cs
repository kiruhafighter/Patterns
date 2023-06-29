namespace AdapterPattern.DataProcessor
{
    public class DataProcessor : IDataProcessor
    {
        public bool DataProcess()
        {
            Console.WriteLine("Processed data");
            return true;
        }

        public void SendNetworkRequest(string ip, string apiKey)
        {
            Console.WriteLine("Send network request with IP address that requires API KEY: " + ip);
        }
    }
}
