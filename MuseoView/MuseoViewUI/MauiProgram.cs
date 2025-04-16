using Database;
using Database.Data;
using Database.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MuseoViewUI.ViewModels;

namespace MuseoViewUI;

public static class MauiProgram
{
    public static IServiceProvider Services => Current.Services;

    private static MauiApp _mauiApp;
    public static MauiApp Current => _mauiApp ?? throw new InvalidOperationException("MauiApp is not initialized yet.");

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		//builder
		//	.UseMauiApp<App>()
		//	.ConfigureFonts(fonts =>
		//	{
		//		fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
		//		fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		//	});

        builder.Services.AddSingleton<MuseumDatabase>(serviceProvider =>
                new MuseumDatabase(DatabaseConfig.DbPath));  // Път към базата

        builder.Services.AddSingleton<MuseumDatabaseService>();

        builder.Services.AddSingleton<MuseumSearchViewModel>();  // Регистрираме ViewModel-а
        builder.Services.AddSingleton<MuseumDetailsViewModel>();


        builder.Services.AddSingleton<MuseumsByObjectViewModel>();  // Регистрираме ViewModel-а

        builder.Services.AddSingleton<MainPage>();  // Регистрираме MainPage с DI контейнера

        builder.UseMauiApp<App>();  // Настройваме основното приложение
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
