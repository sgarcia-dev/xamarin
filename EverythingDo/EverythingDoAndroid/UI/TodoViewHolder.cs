using System;
using Android.Support.V7.Widget;
using Android.Widget;
using Android.Views;

namespace EverythingDoAndroid
{
	public class TodoViewHolder : RecyclerView.ViewHolder
	{
		public TextView NameTextView {
			get;
			set;
		}

		public TextView DescriptionTextView {
			get;	
			set;
		}

		public TodoViewHolder (View itemView, Action<int> clickHandler) : base(itemView) {
			this.NameTextView = itemView.FindViewById<TextView> (Resource.Id.homeRecyclerViewNameText);
			this.DescriptionTextView = itemView.FindViewById<TextView> (Resource.Id.homeRecyclerViewDescriptionText);

			itemView.Click += (object sender, EventArgs e) => clickHandler(Position);
		}
	}
}

