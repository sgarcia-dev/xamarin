using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace todo
{
	public class App : Application
	{
		public App()
		{
			var urlstring = DependencyService.Get<IDeviceData>().GetLocalFilePath("database");
			// The root page of your application
			MainPage = new NavigationPage(new HomePage(urlstring));
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
