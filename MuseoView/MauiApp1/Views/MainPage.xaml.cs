using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using MuseoView.ViewModels;
namespace MuseoView.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Ако искаш да добавиш специални маркери или настройки:
        var map = mapView;
        var position = new Location(42.6955, 23.3219); // Примерни координати за България
        var mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromMiles(10));
        map.MoveToRegion(mapSpan);

        // Добави маркер за конкретна локация
        var pin = new Pin
        {
            Type = PinType.Place,
            Location = position,
            Label = "Примерен музей",
            Address = "Адрес на музея"
        };
        map.Pins.Add(pin);
    }
}