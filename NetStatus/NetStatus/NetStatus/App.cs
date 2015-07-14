using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Connectivity.Plugin;
using Connectivity.Plugin.Abstractions;

namespace NetStatus
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			MainPage = CrossConnectivity.Current.IsConnected
				? (Page)new NetworkViewPage()
				: new NoNetworkPage();
		}

		protected override void OnStart()
		{
			CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
		}

		void HandleConnectivityChanged (object sender, Connectivity.Plugin.Abstractions.ConnectivityChangedEventArgs e)
		{
			Type currentPage = this.MainPage.GetType();
			if (e.IsConnected && currentPage != typeof(NetworkViewPage))
				this.MainPage = new NetworkViewPage();
			else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
				this.MainPage = new NoNetworkPage();
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
