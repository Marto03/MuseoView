using Database;
using Database.Data;
using Microsoft.Extensions.DependencyInjection;
using MuseoViewUI.ViewModels;

namespace MuseoViewUI
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            //var builder = MauiApp.CreateBuilder();
            //builder.Services.AddSingleton<MuseumDatabase>(serviceProvider =>
            //    new MuseumDatabase(DatabaseConfig.DbPath));

            // Регистрираме ViewModel-а, който ще бъде инжектиран в MainPage
            //builder.Services.AddSingleton<MuseumSearchViewModel>();

            //DependencyService.Register<MuseumDatabase>();
            //DependencyService.Register<MuseumSearchViewModel>();

            InitializeDatabase();
            MainPage = serviceProvider.GetRequiredService<MainPage>();
        }
        private async void InitializeDatabase()
        {
            var museumDatabaseService = new MuseumDatabase(DatabaseConfig.DbPath);
            await museumDatabaseService.InitializeDatabaseAsync(); // Изчакваме създаването на таблиците и инициализацията на данните
        }
    }
}
