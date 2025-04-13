using MuseoViewUI.ViewModels;
using Microsoft.Maui.Controls;

namespace MuseoViewUI.Views
{
    [QueryProperty(nameof(MuseumId), "museumId")]
    public partial class MuseumDetailsView : ContentPage
    {
        public int MuseumId { get; set; }

        private MuseumDetailsViewModel ViewModel => BindingContext as MuseumDetailsViewModel;

        public MuseumDetailsView(MuseumDetailsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = MauiProgram.Services.GetService<MuseumDetailsViewModel>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (MuseumId != 0 && ViewModel != null)
            {
                await ViewModel.LoadMuseumAsync(MuseumId);
            }
        }
    }
}
