using BusinessLayer;
using BusinessLayer.Interfaces;
using Microsoft.Extensions.Logging;
using MuseoViewUI.ViewModels;
using MuseoViewUI.Views;
using Database.Data;

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
        //builder.Services.AddMauiBlazorWebView(); // ако го няма вече

        Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("EnableJavaScript", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.Settings.JavaScriptEnabled = true;
            handler.PlatformView.Settings.DomStorageEnabled = true;
            handler.PlatformView.FilterTouchesWhenObscured = true;
            handler.PlatformView.Settings.AllowFileAccess = true;
#if DEBUG && ANDROID
            Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
#endif

            handler.PlatformView.Settings.AllowContentAccess = true;
            handler.PlatformView.Settings.MixedContentMode = Android.Webkit.MixedContentHandling.AlwaysAllow;
            handler.PlatformView.SetLayerType(Android.Views.LayerType.Hardware, null);
#endif
        });
        builder.Services.AddSingleton<IMuseumService>(s =>
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "museum.db");

            // Използваме фабриката от BusinessLayer
            return MuseumServiceFactory.Create(dbPath);
        });
        builder.Services.AddSingleton<MuseumSearchViewModel>();  // Регистрираме ViewModel-а
        builder.Services.AddSingleton<MuseumDetailsViewModel>();


        builder.Services.AddSingleton<MuseumSearchView>();  // Регистрираме MuseumSearchView с DI контейнера

        builder.UseMauiApp<App>();  // Настройваме основното приложение
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
