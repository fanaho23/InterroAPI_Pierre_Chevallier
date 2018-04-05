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
    public class Inscription
    {
        [JsonProperty("numeroFormation")]
        public string numeroFormation { get; set; }
        [JsonProperty("codeAgent")]
        public string codeAgent { get; set; }
        [JsonProperty("presence")]
        public string presence { get; set; }
    }
}