using MuseoViewUI.ViewModels;

namespace MuseoViewUI
{
    public partial class MainPage : ContentPage
    {
        private MuseumSearchViewModel viewModel;
        public MainPage(MuseumSearchViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            BindingContext = viewModel;
            string embedUrl = "https://www.google.com/maps/embed?pb=!4v1744741942565!6m8!1m7!1sCAoSF0NJSE0wb2dLRUlDQWdJQ0U4S1g0OGdF!2m2!1d43.39868195395627!2d24.60625580766369!3f311.08076926169485!4f-16.784185668013805!5f0.4000000000000002";

            //PanoramaWebView.Source = new UrlWebViewSource
            //{
            //    Url = "file:///android_asset/streetview.html"
            //};


        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnSearchCompleted(object sender, EventArgs e)
        {

        }

        private void OnSearchClicked(object sender, EventArgs e)
        {

        }

        //private void OnRemainingItemsThresholdReached(object sender, EventArgs e)
        //{
        //    var viewModel = BindingContext as MuseumSearchViewModel;
        //    if (viewModel != null)
        //    {
        //        viewModel.OnRemainingItemsThresholdReached(); // Извикваме метода, който контролира зареждането
        //    }
        //}

        private bool isLoading = false;

        //private async void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        //{
        //    // Примерна проверка: ако последният видим елемент е последният в списъка
        //    var viewModel = BindingContext as MuseumSearchViewModel;
        //    if (viewModel == null || isLoading)
        //        return;

        //    int lastVisibleIndex = e.LastVisibleItemIndex;
        //    int totalCount = viewModel.FilteredResults.Count;

        //    // Само ако сме на последния елемент
        //    if (lastVisibleIndex >= totalCount - 1)
        //    {
        //        isLoading = true;

        //        await viewModel.LoadNextPageAsync();

        //        isLoading = false;
        //    }
        //}

        //private void OnRemainingItemsThresholdReached(object sender, EventArgs e)
        //{
        //    if (BindingContext is MuseumSearchViewModel vm)
        //    {
        //        vm.LoadNextPage();
        //    }
        //}

    }

}
