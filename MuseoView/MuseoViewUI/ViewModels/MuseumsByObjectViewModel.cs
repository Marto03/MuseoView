using Database.Data;
using Database.DTOs;
using Database.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoViewUI.ViewModels
{
    public class MuseumsByObjectViewModel : BaseViewModel
    {
        private readonly MuseumDatabase _museumService;
        private string _regionName;

        public ObservableCollection<MuseumDTO> Museums { get; } = new();

        public string RegionName
        {
            get => _regionName;
            set => SetProperty(ref _regionName, value);
        }

        public MuseumsByObjectViewModel(MuseumDatabase museumService)
        {
            _museumService = museumService;
        }

        public async Task LoadMuseumsByRegionAsync(int regionId, string regionName)
        {
            RegionName = regionName;

            var museums = await _museumService.GetMuseumsDTOByRegionAsync(regionId);
            Museums.Clear();
            foreach (var museum in museums)
                Museums.Add(museum);
        }
    }

}
