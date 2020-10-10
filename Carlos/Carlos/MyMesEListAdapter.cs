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
    public class MyMesEListAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        public List<MesasE> mese = new List<MesasE>();

        public MyMesEListAdapter(List<MesasE> mmesaData)
        {
            mese= mmesaData;
        }

        public override int ItemCount
        {
            get { return mese.Count(); }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MesERowViewHolder vh = holder as MesERowViewHolder;
            vh.Title.Text = mese[position].Title;
            vh.Seats.Text = mese[position].Seats;
            vh.AvlTables.Text = mese[position].AvlTables;
            vh.AvgResvTime.Text = mese[position].AvgResvTime;
            vh.Name.Text = mese[position].Name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.MesERow, parent, false);
            MesERowViewHolder vh = new MesERowViewHolder(itemView, OnClick);
            return vh;
        }

        private void OnClick(int obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }
    }
}