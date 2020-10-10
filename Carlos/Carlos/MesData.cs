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
    public class MesData
    {
        public List<Mesas> _MesData_()
        {
            List<Mesas> mesData = new List<Mesas>(){
                new Mesas() { TableDesc = "Mesa para dos",NumOfPer = "2 Personas",NumOfTab = "4 Mesas"},
                new Mesas() { TableDesc = "Mesa para dos",NumOfPer = "2 Personas",NumOfTab = "4 Mesas"},
                new Mesas() { TableDesc = "Mesa para dos",NumOfPer = "2 Personas",NumOfTab = "4 Mesas"},
                new Mesas() { TableDesc = "Mesa para dos",NumOfPer = "2 Personas",NumOfTab = "4 Mesas"},
                new Mesas() { TableDesc = "Mesa para dos",NumOfPer = "2 Personas",NumOfTab = "4 Mesas"},
            };
            return mesData;
        }
    }
}