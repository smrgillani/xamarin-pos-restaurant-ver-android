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

namespace Carlos
{
    public class MyRestaurantListAdapter : BaseAdapter<Restaurant>
    {
        List<Restaurant> rests;

        public MyRestaurantListAdapter(List<Restaurant> rests)
        {
            this.rests = rests;
        }

        public override Restaurant this[int position]
        {
            get
            {
                return rests[position];
            }
        }

        public override int Count
        {
            get
            {
                return rests.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ResRow, parent, false);

                var Name_ = view.FindViewById<TextView>(Resource.Id.restTitle_);
                var NameSub_ = view.FindViewById<TextView>(Resource.Id.restTitlesub_);
                var AddressOne_ = view.FindViewById<TextView>(Resource.Id.restAddrone_);
                var AddressTwo_ = view.FindViewById<TextView>(Resource.Id.restAddrtwo_);
                var AddressThr_ = view.FindViewById<TextView>(Resource.Id.restAddrthr_);
                
                view.Tag = new RestRowViewHolder() { Name = Name_ , NameSub = NameSub_,AddressOne = AddressOne_ , AddressTwo = AddressTwo_ , AddressThr = AddressThr_ };
            }

            var holder = (RestRowViewHolder)view.Tag;

            holder.Name.Text = rests[position].Name;
            holder.NameSub.Text = rests[position].NameSub;
            holder.AddressOne.Text = rests[position].AddressOne;
            holder.AddressTwo.Text = rests[position].AddressTwo;
            holder.AddressThr.Text = rests[position].AddressThree;
            return view;

        }
    }
}