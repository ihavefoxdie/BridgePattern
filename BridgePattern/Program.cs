using BridgePattern;

Client client = new();

Console.WriteLine("Gaming device: ");
client.DoStuff(new Controller(new GamingConsole()));

Console.WriteLine("\nSmartTV device: ");
client.DoStuff(new Controller(new SmartTV()));
