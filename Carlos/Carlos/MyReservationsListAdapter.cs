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
    public class MyReservationsListAdapter : BaseAdapter<Reservation>
    {
        List<Reservation> resrs;

        public MyReservationsListAdapter(List<Reservation> resrs)
        {
            this.resrs = resrs;
        }

        public override Reservation this[int position]
        {
            get
            {
                return resrs[position];
            }
        }

        public override int Count
        {
            get
            {
                return resrs.Count;
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
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ResrRow, parent, false);

                var Date_ = view.FindViewById<TextView>(Resource.Id.ResrDateTxt);
                var Time_ = view.FindViewById<TextView>(Resource.Id.ResrTimeTxt);
                var Person_ = view.FindViewById<TextView>(Resource.Id.ResrPersonNumTxt);
                var Area_ = view.FindViewById<TextView>(Resource.Id.ResrAreaLocTxt);
                var Note_ = view.FindViewById<TextView>(Resource.Id.ResrNoteDescTxt);
                var Code_ = view.FindViewById<TextView>(Resource.Id.ResrConfCodeTxt);

                view.Tag = new ResrRowViewHolder(){ Resr_Date = Date_ , Resr_Time = Time_ , Resr_Person = Person_ , Resr_Area = Area_ , Resr_Note = Note_ , Resr_Code = Code_};
                //view.Tag = new ResrRowViewHolder() { Resr_Date = Date_};

            }

            var holder = (ResrRowViewHolder)view.Tag;

            holder.Resr_Date.Text = resrs[position].ResrDate;
            holder.Resr_Time.Text = resrs[position].ResrTime;
            holder.Resr_Person.Text = resrs[position].ResrPersons;
            holder.Resr_Area.Text = resrs[position].ResrArea;
            holder.Resr_Note.Text = resrs[position].ResrNote;
            holder.Resr_Code.Text = resrs[position].ResrCode;
            return view;

        }
    }
}