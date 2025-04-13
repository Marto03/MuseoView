using Database.Data;
using Database.DTOs;
using Database.Services;
using MuseoViewUI.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MuseoViewUI.ViewModels
{
    public class MuseumsByObjectViewModel : BaseViewModel
    {
        private readonly MuseumDatabase _museumService;
        private string _regionName;
        private MuseumDTO _selectedMuseum;

        private readonly Action<int> _navigateToMuseumById;
        public ICommand MuseumTappedCommand { get; }
        public ObservableCollection<MuseumDTO> Museums { get; } = new();
        public ICommand SelectMuseumCommand { get; }

        public string RegionName
        {
            get => _regionName;
            set => SetProperty(ref _regionName, value);
        }

        public MuseumsByObjectViewModel(MuseumDatabase museumService, Action<int> navigateToMuseumDetails)
        {
            _museumService = museumService;
            _navigateToMuseumById = navigateToMuseumDetails;
            //SelectMuseumCommand = new RelayCommand<MuseumDTO>(museum =>
            //{
            //    _navigateToMuseumById?.Invoke(museum.Id);
            //});
            MuseumTappedCommand = new Command<MuseumDTO>(OnMuseumTapped);
        }
        public MuseumDTO SelectedMuseum
        {
            get => _selectedMuseum;
            set
            {
                if (SetProperty(ref _selectedMuseum, value) && value != null)
                {
                    _navigateToMuseumById?.Invoke(value.Id);
                }
            }
        }
        private void OnMuseumTapped(MuseumDTO museum)
        {
            if (museum != null)
            {
                _navigateToMuseumById?.Invoke(museum.Id);
            }
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
