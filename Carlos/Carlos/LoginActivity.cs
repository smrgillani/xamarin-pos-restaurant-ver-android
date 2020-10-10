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
    [Activity(Label = "LoginActivity", Theme = "@style/MyTheme")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);
            Button LoginBtn = FindViewById<Button>(Resource.Id.loginbtn);
            Button RegBtn = FindViewById<Button>(Resource.Id.registerbtn);
            LoginBtn.Click += LoginBtn_Click;
            RegBtn.Click += RegBtn_Click;
            // Create your application here
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Application.Context, typeof(SignupActivity)));
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
            //    AlertDialog.Builder alert = new AlertDialog.Builder(this);
            //    alert.SetTitle("Confirm delete");
            //    alert.SetMessage("Lorem ipsum dolor sit amet, consectetuer adipiscing elit.");
            //    alert.SetPositiveButton("Delete", (senderAlert, args) => {
            //        Toast.MakeText(this, "Deleted!", ToastLength.Short).Show();
            //    });

            //    alert.SetNegativeButton("Cancel", (senderAlert, args) => {
            //        Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
            //    });

            //    Dialog dialog = alert.Create();
            //    dialog.Show();
        }
    }
}