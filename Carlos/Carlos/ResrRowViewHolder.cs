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
    public class ResrRowViewHolder : Java.Lang.Object
    {
        //public TextView Resr_Id { get; set; }
        public TextView Resr_Date { get; set; }
        public TextView Resr_Time { get; set; }
        public TextView Resr_Person { get; set;}
        public TextView Resr_Area { get; set; }
        public TextView Resr_Note { get; set; }
        public TextView Resr_Code { get; set; }
    }
}