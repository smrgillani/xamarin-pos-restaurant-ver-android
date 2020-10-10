using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Support.V7.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Carlos
{
    public class MyHoraListAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        public List<Horarios> google = new List<Horarios>();

        public MyHoraListAdapter(List<Horarios> mhoraData)
        {
            google = mhoraData;
        }

        public override int ItemCount
        {
            get { return google.Count(); }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            HoraRowViewHolder vh = holder as HoraRowViewHolder;
            vh.DayName.Text = google[position].DayName;
            vh.DayTiming.Text = google[position].DayTime;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.HoraRow, parent, false);
            HoraRowViewHolder vh = new HoraRowViewHolder(itemView, OnClick);
            return vh;
        }

        private void OnClick(int obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }
    }
}