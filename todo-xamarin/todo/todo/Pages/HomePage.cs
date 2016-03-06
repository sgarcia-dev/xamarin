using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace todo
{
	public class HomePage : ContentPage
	{
		// homepage constructor
		public HomePage(string urlstring)
		{
			// page configuration
			this.Title = "Todo";

			// UI building
			var pageLayout = new StackLayout();

			var textLabel = new Label
			{
				Text = urlstring
			};

			pageLayout.Children.Add(textLabel);

			// Set page UI
			Content = pageLayout;
		}
	}
}
