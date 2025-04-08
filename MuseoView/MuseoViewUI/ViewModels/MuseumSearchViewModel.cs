using Database.Data;
using Database.DTOs;
using Database.Models;
using MuseoViewUI.Commands;
using MuseoViewUI.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MuseoViewUI.ViewModels
{
    public class MuseumSearchViewModel : BaseViewModel
    {
        private readonly MuseumDatabase museumDatabaseService;
        private string _searchText;
        private string _selectedRegion;
        private string _selectedSearchOption;
        private ObservableCollection<string> _filteredResults;
        private ObservableCollection<string> _regions;
        private ObservableCollection<MuseumDTO> _museums;
        private bool _isMuseumListVisible;

        public MuseumSearchViewModel(MuseumDatabase museumDatabaseService)
        {
            this.museumDatabaseService = museumDatabaseService;
            SearchOptions = new ObservableCollection<string> { "Област", "Музей" };
            Regions = new ObservableCollection<string>();
            Museums = new ObservableCollection<MuseumDTO>();
            FilteredResults = new ObservableCollection<string>();

            SelectRegionCommand = new RelayCommand<string>(async region => await LoadMuseums(region));
            IsMuseumListVisible = false; // Първоначално списъкът с музеи не се вижда.

            InitializeAsync(); // Fire and forget
        }




        //private RegionModel _selectedItem;
        //public RegionModel SelectedItem
        //{
        //    get => _selectedItem;
        //    set
        //    {
        //        if (SetProperty(ref _selectedItem, value) && value != null)
        //        {
        //            // Извикваме метода за навигация
        //            _ = NavigateToMuseumsByRegionAsync(value);
        //        }
        //    }
        //}


        private object _selectedItem;
        public object SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (SetProperty(ref _selectedItem, value) && value != null)
                {
                    if (SelectedSearchOption == "Област" && value is RegionModel region)
                    {
                        _ = NavigateToMuseumsByRegionAsync(region);
                    }
                    // else if (SelectedSearchOption == "Музей" && value is string museumName)
                    // {
                    //     // можеш да добавиш навигация за музей тук
                    // }
                }
            }
        }



        private async Task NavigateToMuseumsByRegionAsync(RegionModel region)
        {

            var viewModel = new MuseumsByObjectViewModel(museumDatabaseService);
            await viewModel.LoadMuseumsByRegionAsync(region.Id, region.Name);

            var page = new MuseumsByObjectView
            {
                BindingContext = viewModel
            };

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }







        private async Task InitializeAsync()
        {
            await LoadRegionsFromDatabaseAsync();
            await LoadMuseums();
        }

        public ObservableCollection<string> SearchOptions { get; set; }

        public string SelectedSearchOption
        {
            get => _selectedSearchOption;
            set
            {
                if (_selectedSearchOption != value)
                {
                    _selectedSearchOption = value;
                    OnPropertyChanged();
                    FilterResults();
                }
            }
        }

        public ObservableCollection<string> FilteredResults
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

        public ObservableCollection<string> Regions
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

        public string SelectedRegion
        {
            get => _selectedRegion;
            set
            {
                if (_selectedRegion != value)
                {
                    _selectedRegion = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsMuseumListVisible
        {
            get => _isMuseumListVisible;
            set
            {
                _isMuseumListVisible = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectRegionCommand { get; }

        private async Task LoadRegionsFromDatabaseAsync()
        {
            var allRegions = await museumDatabaseService.GetAllRegionsAsync();
            Regions = new ObservableCollection<string>(allRegions);
            FilterResults();
        }

        private async Task LoadMuseums(string region = null)
        {
            if (string.IsNullOrEmpty(region))
            {
                var allMuseums = await museumDatabaseService.GetAllMuseumNamesAsync();
                Museums = new ObservableCollection<MuseumDTO>(allMuseums);
            }
            else
            {
                var museums = await museumDatabaseService.GetAllMuseumNamesAsync();
                Museums = new ObservableCollection<MuseumDTO>(museums);
            }
            FilterResults();
        }

        private void FilterResults()
        {
            if (string.IsNullOrEmpty(SelectedSearchOption)) return;

            IEnumerable<string> source = SelectedSearchOption == "Област" ? Regions : Museums.Select(m => m.Name);

            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                source = source.Where(x => x.ToLower().Contains(SearchText.ToLower()));
            }

            FilteredResults = new ObservableCollection<string>(source.Take(50)); // Ограничаване на резултатите (по избор)
        }

    }
}
