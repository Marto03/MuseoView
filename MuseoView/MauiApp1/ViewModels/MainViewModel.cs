using Microsoft.Maui.Controls.Maps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoView.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Pin> RegionPins { get; set; } = new ObservableCollection<Pin>();

        public MainViewModel()
        {
            LoadRegions();
        }

        private void LoadRegions()
        {
            var regions = new List<(string Name, double Lat, double Lon)>
            {
                ("София", 42.6977, 23.3242),
                ("Пловдив", 42.1354, 24.7453),
                ("Варна", 43.2141, 27.9147),
                ("Бургас", 42.5048, 27.4626),
                ("Велико Търново", 43.0757, 25.6172)
            };

            foreach (var region in regions)
            {
                RegionPins.Add(new Pin
                {
                    Label = region.Name,
                    Location = new Location(region.Lat, region.Lon),
                    Type = PinType.Place
                });
            }
        }
    }
}
