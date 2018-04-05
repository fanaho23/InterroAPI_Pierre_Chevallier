using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace InterroAPI
{
    [Activity(Label = "MainActivity3")]
    public class MainActivity3 : Activity
    {
        string laFormation;
        string laActivite;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main3);
            laActivite = Intent.GetStringExtra("laActivite");
            laFormation = Intent.GetStringExtra("laFormation");
            WebClient wc = new WebClient();
            //Uri url = new Uri();

            // Create your application here
        }
    }
}