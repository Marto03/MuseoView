using MuseoViewUI.ViewModels;
#if ANDROID
using MuseoViewUI.Platforms.Android;
using Android.Webkit;
#endif
namespace MuseoViewUI.Views
{

    public partial class MuseumDetailsView : ContentPage
    {

        public UrlWebViewSource _webViewSource;
        public MuseumDetailsView()
        {
            InitializeComponent();
            //LoadHtmlFromEmbeddedAsync();
            //PanoramaWebView.Source = new UrlWebViewSource
            //{
            //    Url = "https://marto03.github.io/StreetViewIntegration/streetview.html"
            //};
            //PanoramaWebView.Source = new HtmlWebViewSource
            //{
            //    //Url = "file:///android_asset/streetview.html"
            //    //Html = "ms-appx-web:///Resources/Raw/streetview.html"
            //    Html = "file:///android_asset/streetview.html"
            //};
            //PanoramaWebView.Navigated += (s, e) =>
            //{
            //    PanoramaWebView.Reload();
            //    if (e.Result != WebNavigationResult.Success)
            //    {
            //        MainThread.BeginInvokeOnMainThread(() =>
            //        {
            //            DisplayAlert("Error", "Failed to load the WebView content. Please check your internet connection.", "OK");
            //        });
            //    }
            //};

            //MainThread.BeginInvokeOnMainThread(async () =>
            //{
            //await Task.Delay(300); // 300ms забавяне
                    //            PanoramaWebView.Source = new UrlWebViewSource
                    //            {
                    //                Url = "file:///android_asset/streetview.html"
                    //            };

                    //            PanoramaWebView.HandlerChanged += (s, e) =>
                    //            {
                    //#if ANDROID
                    //                if (PanoramaWebView.Handler?.PlatformView is Android.Webkit.WebView nativeWebView)
                    //                {
                    //                    nativeWebView.SetOnTouchListener(new WebViewTouchListener());
                    //                    nativeWebView.LoadUrl("file:///android_asset/streetview.html");
                    //                }
                    //#endif
                    //            };
            //PanoramaWebView.Source = _webViewSource;
            //OnAppearing();
            //});
                        PanoramaWebView.Reload();

            //#if ANDROID
            //            Android.Webkit.WebView webView = (Android.Webkit.WebView)PanoramaWebView.Handler.PlatformView;
            //            webView.ClearCache(true);
            //#endif
            //#if DEBUG && ANDROID
            //            Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
            //#endif
            //PanoramaWebView.Source = "https://marto03.github.io/StreetViewIntegration/streetview.html";
            //PanoramaWebView.Source = PanoramaWebView.Source = "https://www.google.com/maps/embed?pb=!4v1713000301107!6m8!1m7!1sCIHM0ogKEICAgICE8KX48gE!2m2!1d43.398682!2d24.6062558!3f311.08!4f73.22!5f0.7820865974627469";

        }
        protected override void OnAppearing()
        {
            //base.OnAppearing();
            //if (PanoramaWebView.Source == null)
            //{
            //    PanoramaWebView.Source = _webViewSource;
            //}
            //else
            //{
            //    PanoramaWebView.Reload();
            //}

            PanoramaWebView.Loaded += (s, e) =>
            {
#if ANDROID

                var handler = PanoramaWebView.Handler;
                if (handler?.PlatformView is Android.Webkit.WebView nativeWebView)
                {
                    nativeWebView.SetOnTouchListener(new WebViewTouchListener());
                    //nativeWebView.LoadUrl("file:///android_asset/streetview.html");
                    //nativeWebView.Reload(); // принудително презареждане
                    //PanoramaWebView.Reload();

                }
#endif
            };
        }
    }

}