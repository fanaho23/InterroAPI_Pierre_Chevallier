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
using InterroAPI.Model;
using Newtonsoft.Json;

namespace InterroAPI
{
    [Activity(Label = "MainActivity2")]
    public class MainActivity2 : Activity
    {
        Button btnListe;
        Button btnInscription;
        Formation fromation;
        Activite activite;
        string laFormation;
        string laActivite;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main2);
            btnListe = FindViewById<Button>(Resource.Id.btnListe);
            btnInscription = FindViewById<Button>(Resource.Id.btnInscription);
             string laFormation = Intent.GetStringExtra("laFormation");
            string laActivite = Intent.GetStringExtra("laActivite");
            btnListe.Click += BtnListe_Click;
            // Create your application here
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            Intent intentMenu = new Intent(this, typeof(MainActivity2));
            intentMenu.PutExtra("laFormation", JsonConvert.SerializeObject(laFormation));
            intentMenu.PutExtra("laActivite", JsonConvert.SerializeObject(laActivite));
            //Toast.MakeText(this, "Ok", ToastLength.Long).Show();
            StartActivity(intentMenu);
        }
    }
}