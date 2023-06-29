using ChainOfResponsibility;

NetworkModel netModel = new NetworkModel("1.3.1.24.67", false);

IChain sendSSH = new SendSSH();
IChain sendPing = new SendPing();
IChain sendARP = new SendARP();

sendSSH.SetNext(sendPing);
sendPing.SetNext(sendARP);
//sendARP.SetNext(sendSSH);

sendSSH.SendRequest(netModel);