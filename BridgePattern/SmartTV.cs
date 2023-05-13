namespace BridgePattern;

public class SmartTV : Device
{
    private List<string> _launchedApps;
    private bool _powered = false;
    private List<string> _apps;

    public IReadOnlyList<string> InstalledApps
    {
        get
        {
            return _apps;
        }
    }

    public SmartTV()
    {
        _launchedApps = new List<string>();
        _apps = new List<string>();
    }

    public string CurrentApplication()
    {
        if (_launchedApps.Count > 0)
            return _launchedApps.Last();
        return "None";
    }

    public bool ExecuteApplication(string app)
    {
        if (!_apps.Contains(app))
        {
            return false;
        }

        if (_launchedApps.Contains(app))
        {
            var element = _launchedApps[_launchedApps.IndexOf(app)];
            _launchedApps.RemoveAt(_launchedApps.IndexOf(app));
            _launchedApps.Add(element);
            return true;
        }

        _launchedApps.Add(app);
        return true;
    }

    public bool InstallApplication(string app)
    {
        if (InstalledApps.Contains(app))
        {
            return false;
        }
        _apps.Add(app);
        return true;
    }

    public bool IsOn()
    {
        return _powered;
    }

    public void TogglePower()
    {
        if (_powered)
        {
            Console.WriteLine("Powering off...");
            _powered = false;
        }
        else
        {
            _powered = true;
            Console.WriteLine("Welcome!");
        }
    }

    private void ShutdownApplication()
    {
        _launchedApps.Remove(CurrentApplication());
    }

    public bool UninstallApplication(string app)
    {
        if (_launchedApps.Contains(app))
            ShutdownApplication();

        return _apps.Remove(app);
    }
}
