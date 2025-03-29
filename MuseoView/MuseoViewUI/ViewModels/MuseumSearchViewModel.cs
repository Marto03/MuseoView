using Database;
using Database.Data;
using Database.Models;
using MuseoViewUI.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MuseoViewUI.ViewModels
{
    public class MuseumSearchViewModel : INotifyPropertyChanged
    {
        private readonly MuseumDatabase museumDatabaseService;
        private string _searchText;
        private string _selectedRegion;
        private ObservableCollection<string> _filteredRegions;
        private ObservableCollection<MuseumModel> _museums;
        private bool _isMuseumListVisible;

        public event PropertyChangedEventHandler PropertyChanged;

        public MuseumSearchViewModel(MuseumDatabase museumDatabaseService)
        {
            this.museumDatabaseService = museumDatabaseService;
            _filteredRegions = new ObservableCollection<string>();
            _museums = new ObservableCollection<MuseumModel>();
            SelectRegionCommand = new RelayCommand<string>(async region => await LoadMuseums(region));
            IsMuseumListVisible = false; // Задаваме първоначално видимостта на списъка с музеи на "не".
            //InitializeDatabaseAsync();
        }
        private async Task InitializeDatabaseAsync()
        {
            await museumDatabaseService.InitializeDatabaseAsync(); // Изчакваме създаването на таблиците и инициализацията на данните
            LoadRegionsFromDatabaseAsync(); // Може да извикате друга логика след инициализацията
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
                    LoadRegionsFromDatabaseAsync();
                }
            }
        }

        public ObservableCollection<string> FilteredRegions
        {
            get => _filteredRegions;
            set
            {
                _filteredRegions = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<MuseumModel> Museums
        {
            get => _museums;
            set
            {
                _museums = value;
                OnPropertyChanged();
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
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                FilteredRegions.Clear();
                return;
            }

            var allRegions = await museumDatabaseService.GetAllRegionsAsync();
            var matchingRegions = allRegions
                .Where(r => r.ToLower().Contains(SearchText.ToLower()))
                .ToList();

            FilteredRegions = new ObservableCollection<string>(matchingRegions);
        }

        private async Task LoadMuseums(string region)
        {
            if (!string.IsNullOrEmpty(region))
            {
                SelectedRegion = region;
                IsMuseumListVisible = true; // Показваме списъка с музеи, когато е избрана област
                var museums = await museumDatabaseService.GetMuseumsByRegionAsync(region);
                Museums = new ObservableCollection<MuseumModel>(museums);
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

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
