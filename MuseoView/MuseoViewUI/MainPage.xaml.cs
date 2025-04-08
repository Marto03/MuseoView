using MuseoViewUI.ViewModels;

namespace MuseoViewUI
{
    public partial class MainPage : ContentPage
    {
        private MuseumSearchViewModel viewModel1;

        public MainPage(MuseumSearchViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel1 = viewModel;
            BindingContext = viewModel;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnRegionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            viewModel1.SelectedItem = e;
        }

        private void OnMuseumSearchTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnSearchTypeChanged(object sender, EventArgs e)
        {

        }
    }

}
