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
    public class MesEData
    {
        public List<MesasE> _MesEData_()
        {
            List<MesasE> mesEData = new List<MesasE>(){
                new MesasE() { Title = "Tipo de Mesa 1",Seats = "4",AvlTables = "4" , AvgResvTime = "1:00" ,Name = "Mesa para dos"},
                new MesasE() { Title = "Tipo de Mesa 1",Seats = "4",AvlTables = "4" , AvgResvTime = "1:00" ,Name = "Mesa para dos"},
                new MesasE() { Title = "Tipo de Mesa 1",Seats = "4",AvlTables = "4" , AvgResvTime = "1:00" ,Name = "Mesa para dos"},
            };
            return mesEData;
        }
    }
}