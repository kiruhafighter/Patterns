using FacadePattern;

NetworkFacade netFacade = new NetworkFacade("90.61.268.161.11", "UDP");

netFacade.SendPacketOverNetwork();