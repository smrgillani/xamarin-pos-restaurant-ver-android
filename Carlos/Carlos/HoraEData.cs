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
    public class HoraEData
    {
        public List<HorariosE> _HoraEData_()
        {
            List<HorariosE> horaEData = new List<HorariosE>(){
                new HorariosE() { DayName = "Lunes",DayTimeS = "09:00" , DayTimeE = "22:00"},
                new HorariosE() { DayName = "Lunes",DayTimeS = "09:00" , DayTimeE = "22:00"},
                new HorariosE() { DayName = "Lunes",DayTimeS = "09:00" , DayTimeE = "22:00"},
                new HorariosE() { DayName = "Lunes",DayTimeS = "09:00" , DayTimeE = "22:00"},
                new HorariosE() { DayName = "Lunes",DayTimeS = "09:00" , DayTimeE = "22:00"},
                new HorariosE() { DayName = "Lunes",DayTimeS = "09:00" , DayTimeE = "22:00"},
                new HorariosE() { DayName = "Lunes",DayTimeS = "09:00" , DayTimeE = "22:00"},
            };
            return horaEData;
        }
    }
}