using System;

using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;

using AlertDialog = Android.Support.V7.App.AlertDialog;

namespace EverythingDoAndroid
{
	[Activity (Label = "EverythingDo", MainLauncher = true, Icon = "@drawable/icon", Theme="@style/MaterialTheme")]
	public class MainActivity : AppCompatActivity
	{
		public TodoFactoryAndroid TodoFactory = new TodoFactoryAndroid();
		public List<Todo> Todos;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Home);

			InitializeToolbar ();
			Todos = TodoFactory.GetTodos ();
			InitializeRecyclerView ();

			FloatingActionButton fab = FindViewById<FloatingActionButton> (Resource.Id.fab);
			fab.Click += (object sender, EventArgs e) => {
				var builder = new AlertDialog.Builder(this);
				builder.SetTitle("Notification")
					.SetMessage("You clicked the Action Button!")
					.SetPositiveButton("OK", delegate {});
				builder.Create().Show();
			};
		}

		private void InitializeToolbar() {
			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar> (Resource.Id.HomeLayoutToolbar);
			SetSupportActionBar (toolbar);
			SupportActionBar.Title = "Todos";
		}

		private void InitializeRecyclerView () {
			RecyclerView recyclerView = FindViewById<RecyclerView> (Resource.Id.HomeLayoutRecyclerView);
			TodoAdapter adapter = new TodoAdapter (Todos);
			recyclerView.SetAdapter (adapter);

			adapter.ItemClickEvent += (object sender, int position) => {
				var builder = new AlertDialog.Builder(this);
				builder.SetTitle(Todos[position].Name)
					.SetMessage(Todos[position].Description)
					.SetPositiveButton("Got it", delegate {});
				builder.Create().Show();
			};

			recyclerView.SetLayoutManager (new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
		}
	}
}


