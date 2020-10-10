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
    [Activity(Label = "SignupActivity", Theme = "@style/Theme.DesignDemo")]
    public class SignupActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_signup);
            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitle(Resource.String.account_signup);
            SetSupportActionBar(toolbar);
            Button sub = (Button)FindViewById<Button>(Resource.Id.SignupBtn);
            sub.Click += Sub_Click;
            // Create your application here
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
        }
    }
}