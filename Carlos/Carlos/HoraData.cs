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
    public class HoraData
    {
        public List<Horarios> _HoraData_()
        {
            List<Horarios> horaData = new List<Horarios>(){
                new Horarios() { DayName = "Lunes",DayTime = "Cerrado"},
                new Horarios() { DayName = "Lunes",DayTime = "Cerrado"},
                new Horarios() { DayName = "Lunes",DayTime = "Cerrado"},
                new Horarios() { DayName = "Lunes",DayTime = "Cerrado"},
                new Horarios() { DayName = "Lunes",DayTime = "Cerrado"},
                new Horarios() { DayName = "Lunes",DayTime = "Cerrado"},
            };
            return horaData;
        }
    }
}