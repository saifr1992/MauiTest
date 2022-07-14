using MauiTestApp.Interface;
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


        builder.Services.AddSingleton<IPlatformDiTestService, PlatformDiTestService>();

        #region Pages
        ///HomeMainPage
        builder.Services.AddTransient<HomeMainPage>();
        #endregion

        MauiApp mauiApp = builder.Build();
        mauiApp.Services.UseResolver();
        return mauiApp;
    }

    public static void UseResolver(this IServiceProvider serviceProvider)
    {
        Resolver.RegisterServiceProvider(serviceProvider);
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



