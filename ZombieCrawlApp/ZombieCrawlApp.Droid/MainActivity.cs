using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Facebook.Login.Widget;
using Xamarin.Facebook;

namespace ZombieCrawlApp.Droid
{
	[Activity (Label = "ZombieCrawlApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
        private LoginButton loginButton;
        private ICallbackManager callbackManager;

		protected override void OnCreate (Bundle bundle)
		{
            base.OnCreate(bundle);

            FacebookSdk.SdkInitialize(this.ApplicationContext);
            callbackManager = CallbackManagerFactory.Create();
            

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new ZombieCrawlApp.App ());
		}
	}
}

