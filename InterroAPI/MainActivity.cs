using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using System;
using System.Collections.Generic;
using InterroAPI.Model;
using Newtonsoft.Json;
using InterroAPI.MesAdapters;

namespace InterroAPI
{
    [Activity(Label = "InterroAPI", MainLauncher = true)]
    public class MainActivity : Activity
    {
        List<Activite> lstActivite;
        List<Formation> lstFormation;
        ListView lvActivite;
        ListView lvFormation;
        AdapterActivite adapter;
        AdapterFormation adapterForm;
        Activite laActivite;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            lvActivite = FindViewById<ListView>(Resource.Id.lvActivite);
            lvFormation = FindViewById<ListView>(Resource.Id.lvFormation);
            WebClient wc = new WebClient();

            Uri url = new Uri("http://"+ GetString(Resource.String.ip)+ "GetAllActivites.php");
            wc.DownloadStringAsync(url);
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;

        }

        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            lstActivite = JsonConvert.DeserializeObject<List<Activite>>(e.Result);
            adapter = new AdapterActivite(this, lstActivite);
            lvActivite.Adapter = adapter;

            lvActivite.ItemClick += LvActivite_ItemClick;
        }

        private void LvActivite_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            laActivite = lstActivite[e.Position];

            WebClient wc = new WebClient();
            Uri url = new Uri("http://" + GetString(Resource.String.ip) + "GetFormationsByIdActivite.php?idActivite="+laActivite.numero);
            wc.DownloadStringAsync(url);
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted1;

        }

        private void Wc_DownloadStringCompleted1(object sender, DownloadStringCompletedEventArgs e)
        {
            lstFormation = JsonConvert.DeserializeObject<List<Formation>>(e.Result);
            adapterForm = new AdapterFormation(this, lstFormation);
            lvFormation.Adapter = adapterForm;
        }
    }
}

