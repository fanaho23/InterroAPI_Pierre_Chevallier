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
    class AdapterFormation : ArrayAdapter<Formation>
    {

        Activity context;
        List<Formation> lesFormations;

        public AdapterFormation(Activity unContext, List<Formation> desFormations)
            : base(unContext, Resource.Layout.ItemFormation, desFormations)
        {
            this.context = unContext;
            lesFormations = desFormations;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = context.LayoutInflater.Inflate(Resource.Layout.ItemFormation, null);
            view.FindViewById<TextView>(Resource.Id.txtNomFormation).Text = lesFormations[position].intitule.ToString();


            return view;
        }



    }

}