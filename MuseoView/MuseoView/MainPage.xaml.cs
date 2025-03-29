using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls.Maps;
namespace MuseoView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Задаване на начална област (карта на България)
            var initialRegion = new MapSpan(new Location(42.6977, 23.3219), 1, 1); // София, България
            mapView.MoveToRegion(initialRegion); // Премества картата до региона на България
        }
    }

}
