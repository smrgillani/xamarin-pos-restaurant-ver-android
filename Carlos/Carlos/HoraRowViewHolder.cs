using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Carlos
{
    public class HoraRowViewHolder : RecyclerView.ViewHolder
    {
        public TextView DayName { get; set; }
        public TextView DayTiming { get; set; }

        public HoraRowViewHolder(View itemview, Action<int> listener) : base(itemview)
        {
            DayName = itemview.FindViewById<TextView>(Resource.Id.dayname);
            DayTiming = itemview.FindViewById<TextView>(Resource.Id.daytime);
            itemview.Click += (sender, e) => listener(base.Position);
        }
    }
}