using System;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Android.Views;

namespace EverythingDoAndroid 
{
	public class TodoAdapter : RecyclerView.Adapter
	{
		public event EventHandler<int> ItemClickEvent;

		public List<Todo> Todos {
			get;
			set;
		}

		void OnItemClick(int position) {
			if (position != null)
				ItemClickEvent (this, position);
		}

		public TodoAdapter (List<Todo> todos)
		{
			this.Todos = todos;
		}

		public override int ItemCount {
			get {
				return Todos.Count;
			}
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder (Android.Views.ViewGroup parent, int viewType)
		{
			var layout = LayoutInflater.From (parent.Context).Inflate (Resource.Layout.HomeRecyclerViewItem, parent, false);
			return new TodoViewHolder (layout, OnItemClick);
		}

		public override void OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
		{
			var viewHolder = (TodoViewHolder)holder;
			viewHolder.NameTextView.Text = Todos [position].Name;
			viewHolder.DescriptionTextView.Text = Todos [position].Description;
		}
	}
}

