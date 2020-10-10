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
    public class ResrData
    {
        public static List<Reservation> Resrs { get; private set; }

        static ResrData()
        {
            var temp = new List<Reservation>();

            AddResr(temp);
            AddResr(temp);
            AddResr(temp);

            Resrs = temp.OrderBy(i => i.ResrDate).ToList();
        }

        static void AddResr(List<Reservation> resrs)
        {
            resrs.Add(new Reservation()
            {
                ResrDate = "29/11/2018",
                ResrTime = "21:00",
                ResrPersons = "4",
                ResrArea = "Terraza",
                ResrNote = " NOTAS DE LA RESERVACIÓN, ESTE ES UN CAMPO DE TEXTO LARGO, SE MUESTRAN HASTA TRES LINEAS POR REGISTRO ",
                ResrCode = "AJK9571B"
            });
            resrs.Add(new Reservation()
            {
                ResrDate = "29/11/2018",
                ResrTime = "21:00",
                ResrPersons = "4",
                ResrArea = "Terraza",
                ResrNote = " NOTAS DE LA RESERVACIÓN, ESTE ES UN CAMPO DE TEXTO LARGO, SE MUESTRAN HASTA TRES LINEAS POR REGISTRO ",
                ResrCode = "1B579KAJ"
            });
            resrs.Add(new Reservation()
            {
                ResrDate = "29/11/2018",
                ResrTime = "21:00",
                ResrPersons = "4",
                ResrArea = "Terraza",
                ResrNote = " NOTAS DE LA RESERVACIÓN, ESTE ES UN CAMPO DE TEXTO LARGO, SE MUESTRAN HASTA TRES LINEAS POR REGISTRO ",
                ResrCode = "1B575KAJ"
            });
            resrs.Add(new Reservation()
            {
                ResrDate = "29/11/2018",
                ResrTime = "21:00",
                ResrPersons = "4",
                ResrArea = "Terraza",
                ResrNote = " NOTAS DE LA RESERVACIÓN, ESTE ES UN CAMPO DE TEXTO LARGO, SE MUESTRAN HASTA TRES LINEAS POR REGISTRO ",
                ResrCode = "1B179KAJ"
            });
            resrs.Add(new Reservation()
            {
                ResrDate = "29/11/2018",
                ResrTime = "21:00",
                ResrPersons = "4",
                ResrArea = "Terraza",
                ResrNote = " NOTAS DE LA RESERVACIÓN, ESTE ES UN CAMPO DE TEXTO LARGO, SE MUESTRAN HASTA TRES LINEAS POR REGISTRO ",
                ResrCode = "1B579KAF"
            });
            resrs.Add(new Reservation()
            {
                ResrDate = "29/11/2018",
                ResrTime = "21:00",
                ResrPersons = "4",
                ResrArea = "Terraza",
                ResrNote = " NOTAS DE LA RESERVACIÓN, ESTE ES UN CAMPO DE TEXTO LARGO, SE MUESTRAN HASTA TRES LINEAS POR REGISTRO ",
                ResrCode = "AJK9571B"
            });
            resrs.Add(new Reservation()
            {
                ResrDate = "29/11/2018",
                ResrTime = "21:00",
                ResrPersons = "4",
                ResrArea = "Terraza",
                ResrNote = " NOTAS DE LA RESERVACIÓN, ESTE ES UN CAMPO DE TEXTO LARGO, SE MUESTRAN HASTA TRES LINEAS POR REGISTRO ",
                ResrCode = "AJK9571B"
            });
        }
    }
}