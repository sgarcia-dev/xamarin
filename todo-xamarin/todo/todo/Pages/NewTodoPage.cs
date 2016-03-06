using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace todo.Pages
{
	public class NewTodoPage : ContentPage
	{
		public NewTodoPage()
		{
			this.Title = "New Todo";

			var pageContentLayout = new StackLayout();



			Content = pageContentLayout;
		}
	}
}
