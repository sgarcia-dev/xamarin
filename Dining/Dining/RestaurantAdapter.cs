using System;
using Android.Support.V7.Widget;
using Android.Views;
using System.Collections.Generic;

namespace Dining
{
    public class RestaurantAdapter : RecyclerView.Adapter
    {
        public List<Restaurant> Restaurants { get; set; }
        public event EventHandler<int> ItemClick;

        public RestaurantAdapter(List<Restaurant> restaurants)
        {
            Restaurants = restaurants;
        } 

        public override int ItemCount
        {
            get
            {
                return Restaurants.Count;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = (RestaurantViewHolder)holder;
            viewHolder.NameTextView.Text = Restaurants[position].Name;
            viewHolder.RatingsBar.Rating = Restaurants[position].Rating;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Restaurant, parent, false);
            return new RestaurantViewHolder(layout, OnItemClick);
        }

        void OnItemClick(int position)
        {
            if (ItemClick != null)
                ItemClick(this, position);
        }
    }
}