using Database.Data;
using Database.DTOs;
using MuseoViewUI.Commands;
using MuseoViewUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MuseoViewUI.ViewModels
{
    public class MuseumSearchViewModel : BaseViewModel
    {
        private readonly MuseumDatabase museumDatabaseService;
        private string _searchText;
        private RegionDTO _selectedRegion;
        private string _selectedSearchOption;
        private ObservableCollection<MuseumDTO> _filteredResults;
        private ObservableCollection<RegionDTO> _regions;
        private ObservableCollection<MuseumDTO> _museums;
        private bool _isMuseumListVisible;
        private bool isSearchVisible;
        private const int PageSize = 20;
        private int currentPage = 0;
        public MuseumSearchViewModel(MuseumDatabase museumDatabaseService)
        {
            this.museumDatabaseService = museumDatabaseService;
            SearchOptions = new ObservableCollection<string> { "Област", "Музей" };
            Regions = new ObservableCollection<RegionDTO>();
            Museums = new ObservableCollection<MuseumDTO>();
            FilteredResults = new ObservableCollection<MuseumDTO>();

            SelectRegionCommand = new RelayCommand<string>(async region => await LoadMuseums(region));
            IsMuseumListVisible = false; // Първоначално списъкът с музеи не се вижда.
            ViewMoreCommand = new Command<MuseumDTO>(async (museum) => await NavigateToMuseumByIdAsync(museum.Id));
            ToggleSearchCommand = new Command(ToggleSearch);
            //LoadNextPageCommand = new Command(async () => await LoadNextPageAsync());
            InitializeAsync(); // Fire and forget
        }

        private List<MuseumDTO> _allFilteredResults = new(); // пълен филтриран списък
        public bool IsSearchVisible
        {
            get =>  isSearchVisible;
            set
            {
                isSearchVisible = value;
                OnPropertyChanged();
            }
        }
        private bool isLoading = false; // За да предотвратим паралелно зареждане
        //public void LoadNextPage()
        //{
        //    // Проверка дали зареждаме в момента, за да не започне ново зареждане, докато старото не е завършено
        //    if (isLoading)
        //        return;

        //    isLoading = true; // Започваме зареждането

        //    // Асинхронно зареждаме следващите 20 елемента
        //    Task.Run(() =>
        //    {
        //        var nextItems = _allFilteredResults
        //            .Skip(currentPage * PageSize)
        //            .Take(PageSize)
        //            .ToList();

        //        // За да не блокираме UI нишката, актуализираме ObservableCollection на UI нишката

        //            foreach (var item in nextItems)
        //            {
        //                FilteredResults.Add(item);
        //            }

        //            currentPage++; // Увеличаваме страницата
        //            isLoading = false; // Зареждането е завършено
        //    });
        //}
        // Метод за зареждане на нови елементи
        //public async Task LoadNextPageAsync()
        //{
        //    if (currentPage * PageSize >= _allFilteredResults.Count)
        //        return;

        //    var nextItems = _allFilteredResults
        //        .Skip(currentPage * PageSize)
        //        .Take(PageSize)
        //        .ToList();

        //    await Task.Delay(200); // Плавен ефект – махни ако не искаш

        //    foreach (var item in nextItems)
        //        FilteredResults.Add(item);

        //    currentPage++;
        //}
        public ICommand ToggleSearchCommand { get; }
        public ICommand ViewMoreCommand { get; }

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

        private void ToggleSearch()
        {
            IsSearchVisible = !IsSearchVisible;
        }
        private object _selectedItem;
        public object SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (SetProperty(ref _selectedItem, value) && value != null)
                {
                    if (SelectedSearchOption == "Област" && value is RegionDTO region)
                    {
                        _ = NavigateToMuseumsByRegionAsync(region);
                    }
                    else if (SelectedSearchOption == "Музей" && value is MuseumDTO museum)
                    {
                        _ = NavigateToMuseumByIdAsync(museum.Id);
                    }
                }
            }
        }
        private async void NavigateToMuseumById(int MuseumId)
        {

            var viewModel = new MuseumDetailsViewModel(museumDatabaseService);
            await viewModel.LoadMuseumAsync(MuseumId);
            //await viewModel.LoadMuseumsByRegionAsync(region.Id, region.Name);

            var page = new MuseumDetailsView
            {
                BindingContext = viewModel
            };

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
        private async Task NavigateToMuseumsByRegionAsync(RegionDTO region)
        {

            var viewModel = new MuseumsByObjectViewModel(museumDatabaseService, NavigateToMuseumById);
            await viewModel.LoadMuseumsByRegionAsync(region.Id, region.Name);

            var page = new MuseumsByObjectView
            {
                BindingContext = viewModel
            };

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        private async Task NavigateToMuseumByIdAsync(int MuseumId)
        {

            var viewModel = new MuseumDetailsViewModel(museumDatabaseService);
            await viewModel.LoadMuseumAsync(MuseumId);
            //await viewModel.LoadMuseumsByRegionAsync(region.Id, region.Name);

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
        public ObservableCollection<string> MuseumTypes { get; set; }

        private string _selectedMuseumType;
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

        public ObservableCollection<MuseumDTO> FilteredResults
        {
            get => _filteredResults;
            set
            {
                _filteredResults = value;
                OnPropertyChanged();
            }
        }

        private Timer _debounceTimer;
        public string SearchText
        {
            get => _searchText;
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                    _debounceTimer?.Dispose();
                    _debounceTimer = new Timer(_ => FilterResults(), null, 300, Timeout.Infinite);
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
            Regions = new ObservableCollection<RegionDTO>(allRegions);
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
        private bool _isLoading = false;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoadNextPageCommand { get; }
        public bool CanLoadMore => currentPage * PageSize < _allFilteredResults.Count;
        public void OnRemainingItemsThresholdReached()
        {
            // Проверяваме дали има още елементи за зареждане и дали не зареждаме в момента
            if (!IsLoading && CanLoadMore)
            {
                LoadNextPageCommand.Execute(null); // Зареждаме нови елементи
            }

        }
        private CancellationTokenSource _cts;
        //private async void FilterResults()
        //{
        //    IEnumerable<MuseumDTO> filtered = Museums;
        //    _cts?.Cancel(); // Спира предишното търсене
        //    _cts = new CancellationTokenSource();
        //    var token = _cts.Token;

        //    string searchText = SearchText?.ToLower() ?? "";
        //    string region = SelectedRegion?.Name.ToLower() ?? "";
        //    string type = SelectedMuseumType?.ToLower() ?? "";
        //    if (isLoading) return;
        //    try
        //    {
        //        isLoading = true;
        //        var results = await Task.Run(() =>
        //        {
        //            IEnumerable<MuseumDTO> filtered = Museums;

        //            if (!string.IsNullOrWhiteSpace(searchText))
        //                filtered = filtered.Where(m => m.LowerName.Contains(searchText));

        //            if (!string.IsNullOrWhiteSpace(region))
        //                filtered = filtered.Where(m => m.LowerRegion == region);

        //            if (!string.IsNullOrWhiteSpace(type))
        //                filtered = filtered.Where(m => m.LowerMuseumType == type);

        //            return filtered.Take(50).ToList(); // Филтрирай в бекграунд
        //        }, token);

        //        // Обновяваме UI частта само веднъж:
        //        FilteredResults = new ObservableCollection<MuseumDTO>(results);
        //    }
        //    catch (OperationCanceledException)
        //    {
        //        // Игнорирай — предишна заявка е прекъсната
        //    }
        //    finally
        //    {
        //        isLoading = false;
        //    }
        //if (!string.IsNullOrWhiteSpace(SearchText))
        //{
        //    filtered = filtered.Where(m => m.Name?.ToLower().Contains(SearchText.ToLower()) == true);
        //}

        //if (SelectedRegion != null)
        //{
        //    filtered = filtered.Where(m => m.RegionName?.ToLower() == SelectedRegion.Name.ToLower());
        //}

        //if (!string.IsNullOrWhiteSpace(SelectedMuseumType))
        //{
        //    filtered = filtered.Where(m => m.MuseumType?.ToLower() == SelectedMuseumType.ToLower());
        //}

        //FilteredResults = new ObservableCollection<MuseumDTO>(filtered.Take(50)); // без .Take(50)
        //}

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

            FilteredResults = new ObservableCollection<MuseumDTO>(filtered); // без .Take(50)
        }


    }
}
