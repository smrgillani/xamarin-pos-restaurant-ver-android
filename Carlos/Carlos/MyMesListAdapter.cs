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
    public class MyMesListAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        public List<Mesas> mList = new List<Mesas>();

        public MyMesListAdapter(List<Mesas> mmesData)
        {
            mList = mmesData;
        }

        public override int ItemCount
        {
            get { return mList.Count(); }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MesRowViewHolder vh = holder as MesRowViewHolder;
            vh.TableDesc.Text = mList[position].TableDesc;
            vh.NumOfPer.Text = mList[position].NumOfPer;
            vh.NumOfTab.Text = mList[position].NumOfTab;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.MesRow, parent, false);
            MesRowViewHolder vh = new MesRowViewHolder(itemView, OnClick);
            return vh;
        }

        private void OnClick(int obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }
    }
}