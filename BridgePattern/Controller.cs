namespace BridgePattern;

public class Controller
{
    private Device _device;
    public Controller(Device device)
    {
        _device = device;
    }

    private bool PowerCheck()
    {
        if (!_device.IsOn())
            return false;
        return true;
    }

    public void PowerOn()
    {
        if (_device.IsOn()) return;
        _device.TogglePower();
    }

    public void PowerOff()
    {
        if (!_device.IsOn()) return;
        _device.TogglePower();
    }

    public bool LaunchApplication(string app)
    {
        if (PowerCheck())
            return _device.ExecuteApplication(app);
        return false;
    }

    public bool InstallFromShop(string app)
    {
        if (PowerCheck())
        {
            Console.WriteLine("Navigating app in Online Shop");
            return _device.InstallApplication(app);
        }
        return false;
    }

    public bool UninstallCurrentApp()
    {
        if (PowerCheck())
        {
            return _device.UninstallApplication(_device.CurrentApplication());
        }
        return false;
    }
}
