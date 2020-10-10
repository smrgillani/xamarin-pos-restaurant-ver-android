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
    public class ResResultFragment : Android.Support.V4.App.DialogFragment
    {
        public ResResultFragment()
        {

        }

        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            ResResultFragment busrouteFragment = new ResResultFragment();
            return busrouteFragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.activity_resrveresult, null);
            return root;
        }

    }
}