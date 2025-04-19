using BusinessLayer.Interfaces;
using Database.Data;
using Database.DTOs;
using MuseoViewUI.Commands;
using MuseoViewUI.ImageMapper;
using MuseoViewUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MuseoViewUI.ViewModels
{
    public class MuseumSearchViewModel : BaseViewModel
    {
        private readonly IMuseumService museumDatabaseService;
        private string _searchText;
        private RegionDTO _selectedRegion;
        private ObservableCollection<MuseumDTO> _filteredResults;
        private ObservableCollection<RegionDTO> _regions;
        private ObservableCollection<MuseumDTO> _museums;
        private bool isSearchVisible;
        private string _selectedMuseumType;

        public MuseumSearchViewModel(IMuseumService museumDatabaseService)
        {
            this.museumDatabaseService = museumDatabaseService;
            Regions = new ObservableCollection<RegionDTO>();
            Museums = new ObservableCollection<MuseumDTO>();
            FilteredResults = new ObservableCollection<MuseumDTO>();

            ViewMoreCommand = new Command<MuseumDTO>(async (museum) => await NavigateToMuseumByIdAsync(museum.Id));
            ToggleSearchCommand = new Command(ToggleSearch);
            InitializeAsync(); // Fire and forget
        }
        #region Properties
        public bool IsSearchVisible
        {
            get => isSearchVisible;
            set
            {
                isSearchVisible = value;
                OnPropertyChanged();
            }
        }
        public ICommand ToggleSearchCommand { get; }
        public ICommand ViewMoreCommand { get; }



        public ObservableCollection<string> MuseumTypes { get; set; }

        public string SelectedMuseumType
        {
            get => _selectedMuseumType;
            set
            {
                if (_selectedMuseumType != value)
                {
                    _selectedMuseumType = value;
                    OnPropertyChanged();
                    FilterResults();
                }
            }
        }

        public ICommand ClearMuseumTypeCommand => new Command(() =>
        {
            SelectedMuseumType = null;
        });
        public ICommand ClearRegionCommand => new Command(() =>
        {
            SelectedRegion = null;
        });


        public ObservableCollection<MuseumDTO> FilteredResults
        {
            get => _filteredResults;
            set
            {
                _filteredResults = value;
                OnPropertyChanged();
            }
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                    FilterResults();
                }
            }
        }

        public ObservableCollection<RegionDTO> Regions
        {
            get => _regions;
            set
            {
                _regions = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<MuseumDTO> Museums
        {
            get => _museums;
            set
            {
                _museums = value;
                OnPropertyChanged();
            }
        }

        public RegionDTO SelectedRegion
        {
            get => _selectedRegion;
            set
            {
                if (_selectedRegion != value)
                {
                    _selectedRegion = value;
                    OnPropertyChanged();
                    FilterResults();
                }
            }
        }


        #endregion
        #region Private Methods
        private void ToggleSearch()
        {
            IsSearchVisible = !IsSearchVisible;
        }
        private async Task NavigateToMuseumByIdAsync(int MuseumId)
        {
            await MakeVibration();

            var viewModel = new MuseumDetailsViewModel(museumDatabaseService);
            await viewModel.LoadMuseumAsync(MuseumId);

            var page = new MuseumDetailsView
            {
                BindingContext = viewModel
            };

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
        private async Task InitializeAsync()
        {
            MuseumTypes = new ObservableCollection<string>(
                Enum.GetNames(typeof(MuseumTypeEnum))
            );

            await LoadRegionsFromDatabaseAsync();
            await LoadMuseums();
        }
        private async Task MakeVibration()
        {
            Vibration.Vibrate(TimeSpan.FromMilliseconds(2000));
            await Task.Delay(150); // стабилно време
            Vibration.Cancel();
        }
        private async Task LoadRegionsFromDatabaseAsync()
        {
            var allRegions = await museumDatabaseService.GetAllRegionsAsync();
            Regions = new ObservableCollection<RegionDTO>(allRegions);
            FilterResults();
        }

        private async Task LoadMuseums(string region = null)
        {
            if (string.IsNullOrEmpty(region))
            {
                var allMuseums = await museumDatabaseService.GetAllMuseumNamesAsync(RegionImageMapper.RegionNames);
                Museums = new ObservableCollection<MuseumDTO>(allMuseums);
            }
            else
            {
                var museums = await museumDatabaseService.GetAllMuseumNamesAsync(RegionImageMapper.RegionNames);
                Museums = new ObservableCollection<MuseumDTO>(museums);
            }
            FilterResults();
        }
        private void FilterResults()
        {
            IEnumerable<MuseumDTO> filtered = Museums;

            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                filtered = filtered.Where(m => m.Name?.ToLower().Contains(SearchText.ToLower()) == true);
            }

            if (SelectedRegion != null)
            {
                filtered = filtered.Where(m => m.RegionName?.ToLower() == SelectedRegion.Name.ToLower());
            }

            if (!string.IsNullOrWhiteSpace(SelectedMuseumType))
            {
                filtered = filtered.Where(m => m.MuseumType?.ToLower() == SelectedMuseumType.ToLower());
            }

            FilteredResults = new ObservableCollection<MuseumDTO>(filtered); // .Take(50)
        }
        #endregion

    }
}
