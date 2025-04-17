using Database.Data;
using Database.Models;
using MuseoViewUI.ImageMapper;
using System.IO;
using System.Linq;

namespace MuseoViewUI.ViewModels
{
    public class MuseumDetailsViewModel : BaseViewModel
    {
        private readonly MuseumDatabase museumService;
        private MuseumModel _museum;

        public MuseumModel Museum
        {
            get => _museum;
            set
            {
                _museum = value;
                OnPropertyChanged();
            }
        }
        public string RegionName { get; set; }
        public string MuseumType => Enum.GetName(typeof(MuseumTypeEnum), Museum?.TypeStatusId ?? 0);

        public MuseumDetailsViewModel(MuseumDatabase museumService)
        {
            this.museumService = museumService;
        }

        public async Task LoadMuseumAsync(int museumId)
        {
            var firstRegion = RegionImageMapper.RegionNames.First();
            string regionSlug = firstRegion.Value;
            int regionId = firstRegion.Key;
            char regionInitial = regionSlug[0];

            int maxImages = GetMaxImageIndex(regionSlug, museumId, regionInitial);

            _museum = await museumService.GetMuseumByIdAsync(museumId);
            RegionName = await museumService.GetRegionNameByIdAsync(_museum.RegionId);
            OnPropertyChanged(nameof(Museum));
            OnPropertyChanged(nameof(RegionName));
        }



        public static int GetMaxImageIndex(string regionName, int id, char regionInitial)
        {
            string folderPath = Path.Combine("MuseumPictures"); // или пълния път ако е нужен
            string searchPattern = $"{regionName}_{id}_*{regionInitial}.jpg";

            var files = Directory.GetFiles(folderPath, searchPattern);

            int max = 0;

            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var parts = fileName.Split('_');
                if (parts.Length >= 3)
                {
                    var numPart = parts[2].TrimEnd(regionInitial); // "5s" => "5"
                    if (int.TryParse(numPart, out int number))
                    {
                        if (number > max) max = number;
                    }
                }
            }

            return max;
        }

    }
}
