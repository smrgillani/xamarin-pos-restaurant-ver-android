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
    public class HoraERowViewHolder : RecyclerView.ViewHolder
    {
        public TextView DayName { get; set; }
        public TextView DayTimeS { get; set; }
        public TextView DayTimeE { get; set; }

        public HoraERowViewHolder(View itemview, Action<int> listener) : base(itemview)
        {
            DayName = itemview.FindViewById<TextView>(Resource.Id.editarhoradayname);
            DayTimeS = itemview.FindViewById<TextView>(Resource.Id.editarhoratimestart);
            DayTimeE = itemview.FindViewById<TextView>(Resource.Id.editarhoratimeend);
            itemview.Click += (sender, e) => listener(base.Position);
        }
    }
}