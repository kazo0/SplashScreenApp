using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace SplashScreenApp.Droid;

[Activity(
    MainLauncher = true,
    ConfigurationChanges = global::Uno.UI.ActivityHelper.AllConfigChanges,
    WindowSoftInputMode = SoftInput.AdjustNothing | SoftInput.StateHidden
)]
public class MainActivity : Microsoft.UI.Xaml.ApplicationActivity
{
	protected override void OnCreate(Bundle bundle)
	{
		//Uno.Toolkit.UI.ExtendedSplashScreen.Init(this);

		base.OnCreate(bundle);
	}
}
