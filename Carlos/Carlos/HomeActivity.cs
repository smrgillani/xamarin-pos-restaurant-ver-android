
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using SupportFragment = Android.Support.V4.App.Fragment;
using System.Collections.Generic;
using System;
using Android.Content;

namespace Carlos
{
    [Activity(Theme = "@style/Theme.DesignDemo", Icon = "@drawable/menuicon")]
    public class HomeActivity : AppCompatActivity
    {
        DrawerLayout drawerLayout;
        NavigationView navigationView;
        private HomeFragment homeFragment;
        private ResFragment resFragment;
        private MyRestaurantFragment myresFragment;
        private RestConFragment restconFragment;
        private SupportFragment mCurrentFragment = new SupportFragment();
        private Stack<SupportFragment> mStackFragments;
        private V7Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.activity_dashboard);

            // HomeButton_Click;
            resFragment = new ResFragment();
            homeFragment = new HomeFragment();
            restconFragment = new RestConFragment();
            myresFragment = new MyRestaurantFragment();
            mStackFragments = new Stack<SupportFragment>();



            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            // Create ActionBarDrawerToggle button and add it to the toolbar  
            toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            toolbar.SetNavigationIcon(Resource.Drawable.loginlogos);  
            toolbar.SetTitle(Resource.String.app_home);
            SetSupportActionBar(toolbar);
            //
            var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.drawer_open, Resource.String.drawer_close);
            drawerLayout.SetDrawerListener(drawerToggle);
            drawerToggle.SyncState();
            navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected1;
            //setupDrawerContent(navigationView);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.menuicon);

            Android.Support.V4.App.FragmentTransaction tx = SupportFragmentManager.BeginTransaction();

            tx.Add(Resource.Id._main_,resFragment);
            tx.Add(Resource.Id._main_,homeFragment);
            tx.Add(Resource.Id._main_,myresFragment);
            tx.Hide(resFragment);
            tx.Hide(myresFragment);
            //tx.Hide(restconFragment);
            mCurrentFragment = homeFragment;
            
            tx.Commit();
        }
        
        private void NavigationView_NavigationItemSelected1(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.MenuItem.ItemId)
            {
                case (Resource.Id.nav_rest):
                    ShowFragment(homeFragment);
                    toolbar.SetTitle(Resource.String.app_home);
                    break;
                case (Resource.Id.nav_resr):
                    ShowFragment(myresFragment);
                    toolbar.SetTitle(Resource.String.app_reser);
                    break;
                case (Resource.Id.nav_cuen):
                    break;
            }

            drawerLayout.CloseDrawers();
        }

        public void ShowFragment(SupportFragment fragment)
        {
            try
            {
                if (fragment.IsVisible)
                {
                    return;
                }

                var trans = SupportFragmentManager.BeginTransaction();
                fragment.View.BringToFront();
                mCurrentFragment.View.BringToFront();
                trans.Hide(mCurrentFragment);
                trans.Show(fragment);
                trans.AddToBackStack(null);
                mStackFragments.Push(mCurrentFragment);
                trans.Commit();
                mCurrentFragment = fragment;
            }
            catch (Exception e)
            {
                StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
            }

        }


        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            navigationView.InflateMenu(Resource.Menu.nav_menu);
            return true;
        }
    }
}