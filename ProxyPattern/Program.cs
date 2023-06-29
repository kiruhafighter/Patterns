// See https://aka.ms/new-console-template for more information
using ProxyPattern;

ISuperSecret supSecProxy = new SuperSecretDatabaseProxy("InfoDatabase", "Password");

supSecProxy.DisplayDatabaseName();