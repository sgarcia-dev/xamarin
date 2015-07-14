using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace Dining
{
    public class RestaurantViewHolder : RecyclerView.ViewHolder
    {
        public TextView NameTextView { get; set; }
        public RatingBar RatingsBar { get; set; }

        public RestaurantViewHolder(View itemView, Action<int> handler) : base(itemView)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            itemView.Click += (object sender, EventArgs e) => handler(base.Position);
#pragma warning restore CS0618 // Type or member is obsolete

            NameTextView = itemView.FindViewById<TextView>(Resource.Id.nameTextView);
            RatingsBar = itemView.FindViewById<RatingBar>(Resource.Id.ratingsBar);
        }
    }
}