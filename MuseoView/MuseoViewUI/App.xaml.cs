using Database;
using Database.Data;
using Microsoft.Extensions.DependencyInjection;
using MuseoViewUI.ViewModels;
using MuseoViewUI.Views;

namespace MuseoViewUI
{
    public partial class App : Application
    {
        private MuseumDatabase museumDatabaseService;
        public App(IServiceProvider serviceProvider, MuseumDatabase museumDatabaseService)
        {
            InitializeComponent();
            //var builder = MauiApp.CreateBuilder();
            //builder.Services.AddSingleton<MuseumDatabase>(serviceProvider =>
            //    new MuseumDatabase(DatabaseConfig.DbPath));

            // Регистрираме ViewModel-а, който ще бъде инжектиран в MainPage
            //builder.Services.AddSingleton<MuseumSearchViewModel>();

            //DependencyService.Register<MuseumDatabase>();
            //DependencyService.Register<MuseumSearchViewModel>();
            this.museumDatabaseService = museumDatabaseService;
            MainPage = serviceProvider.GetRequiredService<MainPage>();
            MuseumsListView museumsListView = new MuseumsListView();
            InitializeDatabase();
        }
        private async void InitializeDatabase()
        {
            //var museumDatabaseService = new MuseumDatabase(DatabaseConfig.DbPath);
            await museumDatabaseService.InitializeDatabaseAsync(); // Изчакваме създаването на таблиците и инициализацията на данните
        }
    }
}
