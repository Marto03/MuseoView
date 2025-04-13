using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Database.Services;

namespace MuseoViewUI.ViewModels
{
    public class MuseumDetailsViewModel : INotifyPropertyChanged
    {
        private readonly MuseumDatabaseService _museumService;
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

        public MuseumDetailsViewModel(MuseumDatabaseService _museumService)
        {
            this._museumService = _museumService;
        }

        public async Task LoadMuseumAsync(int museumId)
        {
            Museum = await _museumService.GetMuseumByIdAsync(museumId);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
