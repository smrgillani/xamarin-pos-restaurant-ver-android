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
    public class MyRestaurantFragment : Android.Support.V4.App.Fragment
    {
        //ListView myList;
        public HoraData mHoraData;
        public MesData mMesData;
        RecyclerView myList;
        RecyclerView myList_;
        MyHoraListAdapter mAdapter;
        MyMesListAdapter mmAdapter;
        RecyclerView.LayoutManager mLayoutManager;
        RecyclerView.LayoutManager mmLayoutManager;
        public MyRestaurantFragment()
        {

        }
        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            MyRestaurantFragment busrouteFragment = new MyRestaurantFragment();

            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.activity_myrestaurant, null);
            myList = (RecyclerView)root.FindViewById<RecyclerView>(Resource.Id.hlistview);
            myList_ = (RecyclerView)root.FindViewById<RecyclerView>(Resource.Id.mlistview);
            TextView tv = (TextView)root.FindViewById<TextView>(Resource.Id.editarhorarios);
            TextView tv_ = (TextView)root.FindViewById<TextView>(Resource.Id.editarmesas);
            tv.Click += Tv_Click;
            tv_.Click += Tv__Click;
            mLayoutManager = new LinearLayoutManager(Activity);
            mmLayoutManager = new LinearLayoutManager(Activity);
            myList.SetLayoutManager(mLayoutManager);
            myList_.SetLayoutManager(mmLayoutManager);
            mAdapter = new MyHoraListAdapter(new HoraData()._HoraData_());
            mmAdapter = new MyMesListAdapter(new MesData()._MesData_());
            myList.SetAdapter(mAdapter);
            myList_.SetAdapter(mmAdapter);
            //myList.SetAdapter( new MyHoraListAdapter(HoraData.horas));
            //myList.ItemClick += MyList_ItemClick;

            //Button LoginBtn = (Button)root.FindViewById(Resource.Id.dummybutton_);
            //LoginBtn.Click += LoginBtn_Click;
            return root;
        }

        private void Tv__Click(object sender, EventArgs e)
        {
            var activity2 = new Intent(Activity, typeof(MesEActivity));
            StartActivity(activity2);
        }

        private void Tv_Click(object sender, EventArgs e)
        {
            var activity2 = new Intent(Activity, typeof(HoraEActivity));
            StartActivity(activity2);
        }

        public void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var activity2 = new Intent(Activity, typeof(ResDtlActivity));
            StartActivity(activity2);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}