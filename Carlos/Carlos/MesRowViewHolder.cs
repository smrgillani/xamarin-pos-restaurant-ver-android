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
    public class MesRowViewHolder : RecyclerView.ViewHolder
    {
        public TextView TableDesc { get; set; }
        public TextView NumOfPer { get; set; }
        public TextView NumOfTab { get; set; }

        public MesRowViewHolder(View itemview, Action<int> listener) : base(itemview)
        {
            TableDesc = itemview.FindViewById<TextView>(Resource.Id.mesasmpd);
            NumOfPer = itemview.FindViewById<TextView>(Resource.Id.mesasp);
            NumOfTab = itemview.FindViewById<TextView>(Resource.Id.mesasm);
            itemview.Click += (sender, e) => listener(base.Position);
        }
    }
}