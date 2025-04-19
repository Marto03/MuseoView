using BusinessLayer.Interfaces;
using Database.Data;
using Database.Models;
using MuseoViewUI.ImageMapper;
using System.Collections.ObjectModel;

namespace MuseoViewUI.ViewModels
{
    public class MuseumDetailsViewModel : BaseViewModel
    {
        private readonly IMuseumService museumService;
        private MuseumModel _museum;
        private WebViewSource _webViewSource;
        private WebViewSource panoramaViewSource;

        public MuseumDetailsViewModel(IMuseumService museumService)
        {
            this.museumService = museumService;
        }
        public string? MainImagePath { get; set; } // трябва да е на латиница започвайки и завършвайки с буква * blagoevgrad_41_1_b   *
        public string? PanoramaHtmlPath { get; set; }
        public ObservableCollection<string> MuseumImages { get; set; } = new();
        public string MuseumType => Enum.GetName(typeof(MuseumTypeEnum), Museum?.TypeStatusId ?? 0);
        public string RegionName { get; set; }
        public MuseumModel Museum
        {
            get => _museum;
            set
            {
                _museum = value;
                OnPropertyChanged();
            }
        }

        public WebViewSource WebViewSource
        {
            get => _webViewSource;
            set
            {
                _webViewSource = value;
                OnPropertyChanged(nameof(WebViewSource));
            }
        }
        public WebViewSource PanoramaViewSource
        {
            get => panoramaViewSource;
            set
            {
                panoramaViewSource = value;
                OnPropertyChanged(nameof(PanoramaViewSource));
            }
        }


        public async Task LoadMuseumAsync(int museumId)
        {
            _museum = await museumService.GetMuseumByIdAsync(museumId);
            RegionName = await museumService.GetRegionNameByIdAsync(_museum.RegionId);
            await LoadImagesForMuseum(RegionName, museumId);
            OnPropertyChanged(nameof(Museum));
            OnPropertyChanged(nameof(RegionName));
            WebViewSource = new UrlWebViewSource
            {
                Url = $"file:///android_asset/{PanoramaHtmlPath}"
            };
            if (PanoramaHtmlPath == null)
                WebViewSource = new UrlWebViewSource
                {
                    Url = $"file:///android_asset/viewer.html"
                };
            OnPropertyChanged(nameof(WebViewSource));
        }
        private async Task LoadImagesForMuseum(string regionName, int museumId)
        {
            await RegionImageMapper.InitializeAsync();
            await RegionImageMapper.InitializeHtmlAsync();
            var images = RegionImageMapper.GetImages(regionName, museumId);
            var mainImage = RegionImageMapper.GetImages(regionName, museumId, true);
            var htmlPath = RegionImageMapper.GetHtmlFile(regionName, museumId);
            if (htmlPath != null)
                // Зареждаш във WebView или подобен контрол
                PanoramaHtmlPath = htmlPath;


            OnPropertyChanged(nameof(PanoramaHtmlPath));
            MainImagePath = mainImage?.FirstOrDefault() ?? null;
            OnPropertyChanged(nameof(MainImagePath));
            MuseumImages.Clear();
            foreach (var img in images)
                MuseumImages.Add(img);

        }

    }
}
