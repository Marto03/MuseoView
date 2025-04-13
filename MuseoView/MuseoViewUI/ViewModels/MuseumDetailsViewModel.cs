using Database.Data;
using Database.Models;

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
            _museum = await museumService.GetMuseumByIdAsync(museumId);
            RegionName = await museumService.GetRegionNameByIdAsync(_museum.RegionId);
            OnPropertyChanged(nameof(Museum));
            OnPropertyChanged(nameof(RegionName));
        }
    }
}
