using Android.App;
using Android.Content.PM;
using Android.Hardware;
using Android.OS;
using Android.Webkit;
using AWebView = Android.Webkit.WebView;

namespace MuseoViewUI;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity, ISensorEventListener
{
    SensorManager _sensorManager;
    Sensor? _rotationSensor;
    AWebView? _webView;

    protected override void OnCreate(Android.OS.Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        _sensorManager = (SensorManager)GetSystemService(SensorService)!;
        _rotationSensor = _sensorManager.GetDefaultSensor(SensorType.RotationVector);
    }

    public void RegisterGyro(AWebView webView)
    {
        _webView = webView;
        _sensorManager.RegisterListener(this, _rotationSensor, SensorDelay.Game);
    }

    public void UnregisterGyro()
    {
        _sensorManager.UnregisterListener(this);
        _webView = null;
    }

    public void OnSensorChanged(SensorEvent e)
    {
        if (e.Sensor.Type != SensorType.RotationVector || _webView == null)
            return;

        float[] rotationMatrix = new float[9];
        SensorManager.GetRotationMatrixFromVector(rotationMatrix, e.Values.ToArray());

        float[] orientation = new float[3];
        SensorManager.GetOrientation(rotationMatrix, orientation);

        float azimuth = orientation[0]; // Завъртане по Z
        float pitch = orientation[1];   // Наклон
        float roll = orientation[2];    // Странично завъртане

        string js = $"rotateView({azimuth}, {pitch}, {roll});";
        _webView.Post(() => _webView.EvaluateJavascript(js, null));
    }

    public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy) { }
}
