namespace AdapterPattern.DataProcessor
{
    public interface IDataProcessor
    {
        bool DataProcess();
        void SendNetworkRequest(string ip, string apiKey);
    }
}
