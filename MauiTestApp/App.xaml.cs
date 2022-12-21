using MauiTestApp.Service;

namespace MauiTestApp;

public partial class App : Application
{
    private readonly INavigationService _navigationService;
    public App(INavigationService navigationService)
	{
        InitializeComponent();
        MainPage = new AppShell(navigationService);
    }
}

