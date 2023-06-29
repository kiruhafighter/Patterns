using StrategyPattern;

Context context1 = new Context(new Ping());
Context context2 = new Context(new ARP());
Context context3 = new Context(new DNS());

context1.ExecuteStrategy();
context2.ExecuteStrategy();
context3.ExecuteStrategy();