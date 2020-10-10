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
   public class RestConFragment : Android.Support.V4.App.Fragment
    {
        public RestConFragment()
        {

        }

        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            RestConFragment busrouteFragment = new RestConFragment();
            return busrouteFragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.activity_resrveconf, null);
            Button conbtn = (Button)root.FindViewById<Button>(Resource.Id.ResBtnCon);
            conbtn.Click += Conbtn_Click;
            return root;
        }

        private void Conbtn_Click(object sender, EventArgs e)
        {
            //Toast.MakeText(Application.Context, "Got Hit", ToastLength.Short).Show();

            ResResultFragment fragB = new ResResultFragment();
            FragmentManager.BeginTransaction().Replace(Resource.Id._main_, fragB).Commit();

            //var trans = FragmentManager.BeginTransaction().Replace(Resource.Id._main_, new ResResultFragment(), null).AddToBackStack(null).Commit();

        }
    }
}