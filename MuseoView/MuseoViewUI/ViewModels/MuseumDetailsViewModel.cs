using Database.Data;
using Database.Models;
using MuseoViewUI.ImageMapper;
using System.Collections.ObjectModel;

namespace MuseoViewUI.ViewModels
{
    public class MuseumDetailsViewModel : BaseViewModel
    {
        private readonly MuseumDatabase museumService;
        private MuseumModel _museum;
        public string? MainImagePath { get; set; } // трябва да е на латиница започвайки и завършвайки с буква * blagoevgrad_41_1_b   *

        public MuseumModel Museum
        {
            get => _museum;
            set
            {
                _museum = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> MuseumImages { get; set; } = new();
        public string RegionName { get; set; }
        public string MuseumType => Enum.GetName(typeof(MuseumTypeEnum), Museum?.TypeStatusId ?? 0);

        public MuseumDetailsViewModel(MuseumDatabase museumService)
        {
            this.museumService = museumService;
        }

        public async Task LoadMuseumAsync(int museumId)
        {
            //var firstRegion = RegionImageMapper.RegionNames.First();
            //string regionSlug = firstRegion.Value;
            //int regionId = firstRegion.Key;
            //char regionInitial = regionSlug[0];

            //int maxImages = GetMaxImageIndex(regionSlug, museumId, regionInitial);

            _museum = await museumService.GetMuseumByIdAsync(museumId);
            RegionName = await museumService.GetRegionNameByIdAsync(_museum.RegionId);
            LoadImagesForMuseum(RegionName, museumId);
            OnPropertyChanged(nameof(Museum));
            OnPropertyChanged(nameof(RegionName));
        }
        private async Task LoadImagesForMuseum(string regionName, int museumId)
        {
            await RegionImageMapper.InitializeAsync();
            var images = RegionImageMapper.GetImages(regionName, museumId);
            var mainImage = RegionImageMapper.GetImages(regionName, museumId, true);
            MainImagePath = mainImage?.FirstOrDefault() ?? null;
            OnPropertyChanged(nameof(MainImagePath));
            MuseumImages.Clear();
            foreach (var img in images)
                MuseumImages.Add(img);
        }

        //public static int GetMaxImageIndex(string regionName, int museumId, char regionInitial)
        //{
        //    string folderPath = Path.Combine("MuseumPictures");
        //    if (!Directory.Exists(folderPath))
        //        return 0;

        //    string searchPatternStart = $"{regionName}_{museumId}_";
        //    string searchPatternEnd = $"{regionInitial}";

        //    int max = 0;

        //    var files = Directory.GetFiles(folderPath);
        //    foreach (var file in files)
        //    {
        //        var fileName = Path.GetFileNameWithoutExtension(file);
        //        if (fileName.StartsWith(searchPatternStart) && fileName.EndsWith(searchPatternEnd))
        //        {
        //            // Пример: blagoevgrad_41_5b => взимаме "5"
        //            var parts = fileName.Split('_');
        //            if (parts.Length >= 3)
        //            {
        //                string indexPart = parts[2]; // например "5b"
        //                string numberString = new string(indexPart.TakeWhile(char.IsDigit).ToArray());

        //                if (int.TryParse(numberString, out int number))
        //                {
        //                    if (number > max)
        //                        max = number;
        //                }
        //            }
        //        }
        //    }

        //    return max;
        //}

    }
}
