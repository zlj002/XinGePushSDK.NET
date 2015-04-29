using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace XinGePushSDK.NET
{
    
    public class Payload
    {
        public Payload(string alertStr)
        {
            this.alert = alertStr;
            alertJson = null ;
        }
        public Payload(JObject alertJson)
        {
            this.alertJson = alertJson;
            alert = string.Empty;
        }
        public int badge {get;set;}
        public string sound { get; set; }
        public string category { get; set; }
        public string raw { get; set; }
        public string alert { get; set; }

        public JObject alertJson { get; set; }
        
    }
}
