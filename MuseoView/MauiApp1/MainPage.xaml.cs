using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MauiApp1
{
    //public partial class MainPage : ContentPage
    //{
    //    int count = 0;

    //    public MainPage()
    //    {
    //        InitializeComponent();
    //    }

    //    private void OnCounterClicked(object sender, EventArgs e)
    //    {
    //        count++;

    //        if (count == 1)
    //            CounterBtn.Text = $"Clicked {count} time";
    //        else
    //            CounterBtn.Text = $"Clicked {count} times";

    //        SemanticScreenReader.Announce(CounterBtn.Text);
    //    }
    //}
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
}
