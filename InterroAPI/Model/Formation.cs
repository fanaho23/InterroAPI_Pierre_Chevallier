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
using Newtonsoft.Json;

namespace InterroAPI.Model
{
    public class Formation
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("numeroActivite")]
        public string numeroActivite { get; set; }
        [JsonProperty("intitule")]
        public string intitule { get; set; }
    }
}