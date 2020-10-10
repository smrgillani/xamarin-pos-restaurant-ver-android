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
    public class HomeFragment : Android.Support.V4.App.Fragment
    {
        ListView myList;
        public HomeFragment()
        {
            
        }
        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            HomeFragment busrouteFragment = new HomeFragment();

            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.activity_rest, null);
            myList = (ListView)root.FindViewById(Resource.Id.ResrlistView);
            myList.Adapter = new MyReservationsListAdapter(ResrData.Resrs);
            myList.ItemClick += MyList_ItemClick;
            //Button LoginBtn = (Button)root.FindViewById(Resource.Id.dummybutton_);
            //LoginBtn.Click += LoginBtn_Click;
            return root;
        }

        public void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var activity2 = new Intent(Activity, typeof(ResDtlActivity));
            //activity2.PutExtra("MyData", "Data from Activity1");
            StartActivity(activity2);
            //Toast.MakeText(Application.Context, ResrData.Resrs[e.Position].ResrCode, ToastLength.Short).Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}