using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
namespace Carlos
{
    [Activity(Label = "ResDtlActivity", Theme = "@style/Theme.DesignDemo")]
    public class ResDtlActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_ResvDtl);
            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitle(Resource.String.resv_dtls);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.backbtnico);
        }

        //public override void OnBackPressed()
        //{
        //    Toast.MakeText(Application.Context, "Hit", ToastLength.Short).Show();
        //}

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