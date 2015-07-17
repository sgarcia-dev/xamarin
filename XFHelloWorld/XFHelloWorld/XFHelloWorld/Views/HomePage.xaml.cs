using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFHelloWorld.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
			this.Title="My App";

			MyButton.Clicked += (object sender, EventArgs e) => {
				DisplayAlert ("Alert", "You have been alerted", "OK");
			};
        }
    }
}
