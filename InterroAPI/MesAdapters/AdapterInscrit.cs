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

namespace InterroAPI.MesAdapters
{
    class AdapterInscrit : ArrayAdapter<Inscription>
    {

        Activity context;
        List<Inscription> lesInscriptions;

        public AdapterInscrit(Activity unContext, List<Inscription> desInscriptions)
            : base(unContext, Resource.Layout.ItemInscription, desInscriptions)
        {
            this.context = unContext;
            lesInscriptions = desInscriptions;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = context.LayoutInflater.Inflate(Resource.Layout.ItemFormation, null);
             view.FindViewById<TextView>(Resource.Id.txtAgent).Text = lesInscriptions[position].codeAgent.ToString();
            view.FindViewById<TextView>(Resource.Id.txtFormation).Text = lesInscriptions[position].numeroFormation.ToString();

            return view;
        }



    }

}