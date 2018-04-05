using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using System;
using System.Collections.Generic;
using InterroAPI.Model;
using Newtonsoft.Json;

namespace InterroAPI
{
    [Activity(Label = "InterroAPI", MainLauncher = true)]
    public class MainActivity : Activity
    {
        List<Eleve> lstEleve;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Toast.MakeText(this, "hello", ToastLength.Long).Show();
            WebClient wc = new WebClient();
            //Uri url = new Uri("http://" + GetString(Resource.String.ip) + "GetAllInstructeur.php");
            Uri url = new Uri("http://"+ GetString(Resource.String.ip)+"GetAllX.php");
            wc.DownloadStringAsync(url);
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;

        }

        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            lstEleve = JsonConvert.DeserializeObject<List<Eleve>>(e.Result);
            foreach (Eleve eleve in lstEleve)
            {
                Toast.MakeText(this, eleve.prenomEleve +" "+ eleve.nomEleve, ToastLength.Short).Show();
            }
        }
    }
}

