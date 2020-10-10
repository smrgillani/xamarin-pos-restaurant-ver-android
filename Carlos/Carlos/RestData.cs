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
    public static class RestData
    {
        public static List<Restaurant> Rests { get; private set; }

        static RestData()
        {
            var temp = new List<Restaurant>();

            AddRest(temp);
            AddRest(temp);
            AddRest(temp);

            Rests = temp.OrderBy(i => i.Name).ToList();
        }

        static void AddRest(List<Restaurant> rests)
        {
            rests.Add(new Restaurant()
            {
                Name = "Ki Vegan Food",
                NameSub = "Restaurante - Saludable",
                AddressOne = "Av. Londres 134-A",
                AddressTwo = "Col. Roma Norte",
                AddressThree = "Ciudad de México"
            });

            rests.Add(new Restaurant()
            {
                Name = "Ki Vegan Food",
                NameSub = "Restaurante - Saludable",
                AddressOne = "Av. Londres 134-A",
                AddressTwo = "Col. Roma Norte",
                AddressThree = "Ciudad de México"
            });

            rests.Add(new Restaurant()
            {
                Name = "Ki Vegan Food",
                NameSub = "Restaurante - Saludable",
                AddressOne = "Av. Londres 134-A",
                AddressTwo = "Col. Roma Norte",
                AddressThree = "Ciudad de México"
            });

            rests.Add(new Restaurant()
            {
                Name = "Ki Vegan Food",
                NameSub = "Restaurante - Saludable",
                AddressOne = "Av. Londres 134-A",
                AddressTwo = "Col. Roma Norte",
                AddressThree = "Ciudad de México"
            });

            rests.Add(new Restaurant()
            {
                Name = "Ki Vegan Food",
                NameSub = "Restaurante - Saludable",
                AddressOne = "Av. Londres 134-A",
                AddressTwo = "Col. Roma Norte",
                AddressThree = "Ciudad de México"
            });
        }
    }
}