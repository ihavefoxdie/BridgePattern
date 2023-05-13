

namespace BridgePattern;

public class GamingConsole : Device
{
    private string _currentApp = "None";
    private bool _powered = false;
    private List<string> _games;

    public IReadOnlyList<string> InstalledGames
    {
        get
        {
            return _games;
        }
    }



    public GamingConsole()
    {
        _games = new List<string>();
    }
    public GamingConsole(List<string> preinstalledApps)
    {
        _games = preinstalledApps;
    }



    public bool InstallApplication(string app)
    {
        if (InstalledGames.Contains(app))
        {
            return false;
        }
        _games.Add(app);
        return true;
    }

    public bool UninstallApplication(string app)
    {
        if (_currentApp == app)
            ExitApplication();

        return _games.Remove(app);
    }

    private void ExitApplication()
    {
        _currentApp = "None";
    }

    public string CurrentApplication()
    {
        return _currentApp;
    }

    public bool ExecuteApplication(string app)
    {
        if (_currentApp != "None")
            ExitApplication();
        if (!_games.Contains(app))
        {
            return false;
        }
        else
        {
            _currentApp = app;
            return true;
        }
    }

    public bool IsOn()
    {
        return _powered;
    }

    public void TogglePower()
    {
        if (_powered)
        {
            Console.WriteLine("Goodbye!");
            _powered = false;
        }
        else
        {
            _powered = true;
            Console.WriteLine("Welcome!");
        }
    }
}
