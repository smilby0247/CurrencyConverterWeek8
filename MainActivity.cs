using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using CurrencyConverter.Models;

namespace CurrencyConverter
{
    [Activity(Label = "CurrencyConverter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        

        public List<Converter> otherValues { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // list of countries in relationships to the USD

            otherValues = new List<Converter>();
            otherValues.Add(new Converter {Country = "CAD", valueInUSD = 1.31 });
            otherValues.Add(new Converter { Country = "GBP", valueInUSD = 0.92 });
            otherValues.Add(new Converter { Country = "EUR", valueInUSD = 0.54 });

            
        }


    }

   
}

