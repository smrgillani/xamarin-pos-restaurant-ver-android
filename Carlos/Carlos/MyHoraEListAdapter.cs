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
    public class MyHoraEListAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        public List<HorariosE> horae = new List<HorariosE>();

        public MyHoraEListAdapter(List<HorariosE> mhoraData)
        {
            horae = mhoraData;
        }

        public override int ItemCount
        {
            get { return horae.Count(); }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            HoraERowViewHolder vh = holder as HoraERowViewHolder;
            vh.DayName.Text = horae[position].DayName;
            vh.DayTimeS.Text = horae[position].DayTimeS;
            vh.DayTimeE.Text = horae[position].DayTimeE;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.HoraERow, parent, false);
            HoraERowViewHolder vh = new HoraERowViewHolder(itemView, OnClick);
            return vh;
        }

        private void OnClick(int obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }
    }
}