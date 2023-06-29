using Factory_Pattern.NetworkFactory;

NetworkFactory factory = new NetworkFactory();

var ping = factory.GetNetwork("ping");
var arp = factory.GetNetwork("arp");
var dns = factory.GetNetwork("dns");

ping.SendRequest("62.36.5", 8);
arp.SendRequest("241.63.4", 10);
dns.SendRequest("28.35.16", 15);


Console.ReadKey();