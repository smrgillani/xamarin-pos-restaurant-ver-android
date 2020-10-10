using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Carlos
{
    [Activity(Label = "HoraEActivity", Theme = "@style/Theme.DesignDemo")]
    public class HoraEActivity : AppCompatActivity
    {
        public HoraEData mHoraData;
        RecyclerView myList;
        MyHoraEListAdapter mAdapter;
        RecyclerView.LayoutManager mLayoutManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_horae);
            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitle(Resource.String.resv_dtls);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.backbtnico);
            myList = (RecyclerView)FindViewById<RecyclerView>(Resource.Id.hlistview);
            mLayoutManager = new LinearLayoutManager(this);
            myList.SetLayoutManager(mLayoutManager);
            mAdapter = new MyHoraEListAdapter(new HoraEData()._HoraEData_());
            myList.SetAdapter(mAdapter);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}