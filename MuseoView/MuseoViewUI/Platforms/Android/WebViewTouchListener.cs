using Android.Views;
using AView = Android.Views.View;

namespace MuseoViewUI.Platforms.Android
{
#if ANDROID
    public class WebViewTouchListener : Java.Lang.Object, AView.IOnTouchListener
    {
        public bool OnTouch(AView v, MotionEvent e)
        {
            v.Parent?.RequestDisallowInterceptTouchEvent(true);
            return false; // Позволява WebView да обработва жестовете
        }
    }
#endif
}
