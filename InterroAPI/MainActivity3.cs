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
using InterroAPI.MesAdapters;
using InterroAPI.Model;
using Newtonsoft.Json;

namespace InterroAPI
{
    [Activity(Label = "MainActivity3")]
    public class MainActivity3 : Activity
    {
        List<Inscription> lstInscription;
        List<Agent> lstAgents;
        AdapterInscrit adapter;
        ListView lvInscrit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main3);
            lvInscrit = FindViewById<ListView>(Resource.Id.lvInscrit);
            string laActivite = Intent.GetStringExtra("laActivite");

            string laFormation = Intent.GetStringExtra("laFormation");

            Activite activite = JsonConvert.DeserializeObject<Activite>(laActivite);
           Formation formation = JsonConvert.DeserializeObject<Formation>(laFormation);

            WebClient wc = new WebClient();
            Uri url = new Uri("http://" + GetString(Resource.String.ip) + "GetAllInscriptions.php?idFormation="+formation.code);
            wc.DownloadStringAsync(url);
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
            // Create your application here
        }

        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            lstInscription = JsonConvert.DeserializeObject<List<Inscription>>(e.Result);
            adapter = new AdapterInscrit(this, lstInscription);
            lvInscrit.Adapter = adapter;
        }
    }
}