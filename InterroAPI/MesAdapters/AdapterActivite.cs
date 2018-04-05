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
    class AdapterActivite : ArrayAdapter<Activite>
    {

        Activity context;
        List<Activite> lesActivite;

        public AdapterActivite(Activity unContext, List<Activite> desActivites)
            : base(unContext, Resource.Layout.ItemAcitvite, desActivites)
        {
            this.context = unContext;
            lesActivite = desActivites;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = context.LayoutInflater.Inflate(Resource.Layout.ItemAcitvite, null);
            view.FindViewById<TextView>(Resource.Id.txtNumero).Text = lesActivite[position].numero.ToString();
            view.FindViewById<TextView>(Resource.Id.txtLibelle).Text = lesActivite[position].libelle.ToString();
            
            return view;
        }



    }

}