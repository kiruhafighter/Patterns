using AdapterPattern;
using AdapterPattern.DataProcessor;
using AdapterPattern.Network;

INetworkClient network = new NetworkClient();
network.SendRequest("9.0.2.4.1.1");

IDataProcessor dataProc = new DataProcessor();
dataProc.SendNetworkRequest("9.0.2.4.1.1", "27858273uf7g4bt65t7");

Adaptor adapter = new Adaptor(dataProc);
adapter.SendRequest("8.8.8.8");