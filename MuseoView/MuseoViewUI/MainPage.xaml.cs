using MuseoViewUI.ViewModels;

namespace MuseoViewUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MuseumSearchViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnRegionSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }

}
