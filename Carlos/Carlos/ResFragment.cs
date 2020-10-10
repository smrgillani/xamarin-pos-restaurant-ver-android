using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text.Format;
using Android.Views;
using Android.Widget;

namespace Carlos
{
    public class ResFragment : Android.Support.V4.App.DialogFragment
    {
        EditText dateEditText,timeEditText;
        public ResFragment()
        {

        }
        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            ResFragment busrouteFragment = new ResFragment();
            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.activity_resrve, null);
            dateEditText = (EditText)root.FindViewById<EditText>(Resource.Id.ResDate);
            timeEditText = (EditText)root.FindViewById<EditText>(Resource.Id.ResTime);
            dateEditText.Click += DateEditText_Click;
            timeEditText.Click += TimeEditText_Click;
            Button resBtn = (Button)root.FindViewById<Button>(Resource.Id.ResBtn);
            resBtn.Click += ResBtn_Click;

            var spinner_ = (Spinner)root.FindViewById<Spinner>(Resource.Id.ResAreaSel);
            spinner_.ItemSelected += Spinner__ItemSelected;
            var adapter = ArrayAdapter.CreateFromResource(Activity, Resource.Array.area_array, Android.Resource.Layout.SimpleSpinnerDropDownItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner_.Adapter = adapter;
            return root;
        }

        private void TimeEditText_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimePickerDialog dialog = new TimePickerDialog(Activity, 2, (sender_, args) => {
                string amPm = (args.HourOfDay > 12 ? "PM" : "AM");
                View.FindViewById<EditText>(Resource.Id.ResTime).Text = (args.HourOfDay > 12 ? Return12HourNumber(args.HourOfDay) : args.HourOfDay.ToString()) + " " + args.Minute + " " + amPm;
            }, currentTime.Hour, currentTime.Minute, false);
            dialog.Show();
        }

        private void Spinner__ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner_ = sender as Spinner;
            //Toast.MakeText(Application.Context, spinner_.GetItemAtPosition(e.Position).ToString(), ToastLength.Short).Show();
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            RestConFragment fragB = new RestConFragment();
            FragmentManager.BeginTransaction().Replace(Resource.Id._main_, fragB).Commit();
            //var trans = FragmentManager.BeginTransaction().Replace(Resource.Id._main_, new RestConFragment(), null).AddToBackStack(null).Commit();
        }

        private void DateEditText_Click(object sender, EventArgs e)
        {
            DateTime currently = DateTime.Now;
            DatePickerDialog dialog = new DatePickerDialog(Activity, (sender_, args) => { View.FindViewById<EditText>(Resource.Id.ResDate).Text = args.Date.ToString("dd MMM yyyy"); }, currently.Year, currently.Month - 1, currently.Day);
            dialog.Show();
        }

        public string Return12HourNumber(int hour)
        {
            string gethour = "";
            switch (hour)
            {
                case 13:
                    gethour =  "1";
                    break;
                case 14:
                    gethour = "2";
                    break;
                case 15:
                    gethour = "3";
                    break;
                case 16:
                    gethour = "4";
                    break;
                case 17:
                    gethour = "5";
                    break;
                case 18:
                    gethour = "6";
                    break;
                case 19:
                    gethour = "7";
                    break;
                case 20:
                    gethour = "8";
                    break;
                case 21:
                    gethour = "9";
                    break;
                case 22:
                    gethour = "10";
                    break;
                case 23:
                    gethour = "11";
                    break;
                case 24:
                    gethour = "12";
                    break;
                default:
                    gethour = hour.ToString();
                    break;
            }
            return gethour;
        }

    }
}