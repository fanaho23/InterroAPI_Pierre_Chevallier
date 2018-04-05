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
    public class Agent
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("civilite")]
        public string civilite { get; set; }
        [JsonProperty("prenom")]
        public string prenom { get; set; }
        [JsonProperty("nom")]
        public string nom { get; set; }
        [JsonProperty("adresse1")]
        public string adresse1 { get; set; }
        [JsonProperty("codePostal")]
        public string codePostal { get; set; }
        [JsonProperty("ville")]
        public string ville { get; set; }
    }
}