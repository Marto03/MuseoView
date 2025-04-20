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
            PanoramaWebView.Reload();
        }
        protected override void OnAppearing()
        {
            PanoramaWebView.Loaded += (s, e) =>
            {
#if ANDROID
                var handler = PanoramaWebView.Handler;
                if (handler?.PlatformView is Android.Webkit.WebView nativeWebView)
                    nativeWebView.SetOnTouchListener(new WebViewTouchListener());
#endif
            };
        }
    }

}