namespace BridgePattern;

public class Client
{
    public void DoStuff(Controller controller)
    {
        controller.PowerOn();
        controller.InstallFromShop("YouTube");
        controller.LaunchApplication("YouTube");
        controller.UninstallCurrentApp();
        Console.WriteLine(controller.LaunchApplication("YouTube"));
        controller.PowerOff();
    }
}
