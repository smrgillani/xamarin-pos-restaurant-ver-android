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
    public class Reservation
    {
        public string ResrId { get; set; }
        public string ResrDate { get; set; }
        public string ResrTime { get; set; }
        public string ResrPersons { get; set; }
        public string ResrArea { get; set; }
        public string ResrNote { get; set; }
        public string ResrCode { get; set; }
    }
}