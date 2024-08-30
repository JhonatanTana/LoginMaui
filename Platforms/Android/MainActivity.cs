using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using AndroidX.Core.Content;

namespace LoginMaui {
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity {

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            //cor definida no arquivo "Platforms/Android/Resources/values/colors.xml"

            var statusBarColorInt = ContextCompat.GetColor(this, Resource.Color.StatusBar);
            var statusBarColor = new Android.Graphics.Color(statusBarColorInt);
            Window.SetStatusBarColor(statusBarColor);
        }
    }
}
