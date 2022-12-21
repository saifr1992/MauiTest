using MauiTestApp.Service;
using MauiTestApp.ViewModels;
using MauiTestApp.Views;

namespace MauiTestApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        MauiApp mauiApp = builder
            .RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews()
            .Build();
        mauiApp.Services.UseResolver();
        return mauiApp;
    }

    public static void UseResolver(this IServiceProvider serviceProvider)
    {
        Resolver.RegisterServiceProvider(serviceProvider);
    }

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();
        mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<HomeMainPageViewModel>();
        mauiAppBuilder.Services.AddTransient<ManageMainPageViewModel>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<HomeMainPage>();
        mauiAppBuilder.Services.AddTransient<ManageMainPage>();
        return mauiAppBuilder;
    }
}

public static class Resolver
{
    private static IServiceProvider _serviceProvider;
    public static IServiceProvider ServiceProvider => _serviceProvider ?? throw new Exception("Service provider has not been initialized");

    /// <summary>
    /// Register the service provider
    /// </summary>
    public static void RegisterServiceProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    /// <summary>
    /// Get service of type <typeparamref name="T"/> from the service provider.
    /// </summary>
    public static T Resolve<T>()
    {
        return (T)ServiceProvider.GetRequiredService(typeof(T));
    }
}



