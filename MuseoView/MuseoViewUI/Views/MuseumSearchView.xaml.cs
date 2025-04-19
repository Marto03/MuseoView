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

            //if (PanoramaWebView.Handler?.PlatformView is Android.Webkit.WebView nativeWebView)
            //{
            //    nativeWebView.SetOnTouchListener(new WebViewTouchListener());

            //    // Включи gyroscope само при фокус
            //    var activity = Platform.CurrentActivity as MainActivity;
            //    activity?.RegisterGyro(nativeWebView);
            //}
#endif
                    // Load the local HTML (bundled via MauiAsset)
                    //PanoramaWebView.Source = new UrlWebViewSource
                    //{
                    //    Url = "file:///android_asset/viewer.html"
                    //};
        }

        //private void OnRemainingItemsThresholdReached(object sender, EventArgs e)
        //{
        //    var viewModel = BindingContext as MuseumSearchViewModel;
        //    if (viewModel != null)
        //    {
        //        viewModel.OnRemainingItemsThresholdReached(); // Извикваме метода, който контролира зареждането
        //    }
        //}
    }

}
