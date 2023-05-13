namespace BridgePattern;

public interface Device
{
    public void TogglePower();
    public bool IsOn();
    public bool ExecuteApplication(string app);
    public string CurrentApplication();
    public bool InstallApplication(string app);
    public bool UninstallApplication(string app);
}
