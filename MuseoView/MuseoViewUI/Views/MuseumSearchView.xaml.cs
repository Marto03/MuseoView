using Microsoft.Maui.Handlers;
using MuseoViewUI.ViewModels;

namespace MuseoViewUI.Views
{
    public partial class MuseumSearchView : ContentPage
    {
        public MuseumSearchView(MuseumSearchViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Enable JS and local file access
#if ANDROID
            WebViewHandler.Mapper.AppendToMapping("EnableJavaScript", (handler, view) =>
            {
                handler.PlatformView.Settings.JavaScriptEnabled = true;
                handler.PlatformView.Settings.DomStorageEnabled = true;
                handler.PlatformView.Settings.AllowFileAccess = true;
                handler.PlatformView.Settings.AllowFileAccessFromFileURLs = true;
                handler.PlatformView.Settings.AllowUniversalAccessFromFileURLs = true;
            });
#endif
        }
    }

}
