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
    public class MesERowViewHolder : RecyclerView.ViewHolder
    {

        public TextView Title { get; set; }
        public TextView Seats { get; set; }
        public TextView AvlTables { get; set; }
        public TextView AvgResvTime { get; set; }
        public TextView Name { get; set; }

        public MesERowViewHolder(View itemview, Action<int> listener) : base(itemview)
        {
            Title = itemview.FindViewById<TextView>(Resource.Id.mesdesctitle);
            Seats = itemview.FindViewById<TextView>(Resource.Id.mesdescseatingnum);
            AvlTables = itemview.FindViewById<TextView>(Resource.Id.mesdesctabavl);
            AvgResvTime = itemview.FindViewById<TextView>(Resource.Id.mesdescavgresvtime);
            Name = itemview.FindViewById<TextView>(Resource.Id.mesdescname);
            itemview.Click += (sender, e) => listener(base.Position);
        }
    }
}