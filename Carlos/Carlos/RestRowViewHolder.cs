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
    public class RestRowViewHolder : Java.Lang.Object
    {
        public TextView Name { get; set; }
        public TextView NameSub { get; set; }
        public TextView AddressOne { get; set; }
        public TextView AddressTwo { get; set; }
        public TextView AddressThr { get; set; }
    }
}