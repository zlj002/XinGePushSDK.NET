using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XinGePushSDK.NET
{

    public class Msg_IOS : Msg
    {
        private Payload aps { get; set; }
        public Msg_IOS(Payload playload)
            : base(0)
        {
            aps = playload;
        }

        public Msg_IOS(Payload playload,IDictionary<string, string> msg):base(0)
        {
            aps = playload;
        }

        public override string ToJson()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("aps",aps);

             
            if (accept_time.Count > 0)
            {
                JArray array = new JArray(this.accept_time);
                dic.Add("accept_time", array);
            }
            if (this.custom_content.Count > 0)
            {
                dic.Add("custom_content", this.custom_content);
            }
            return JsonConvert.SerializeObject(dic);
        }
    }
}
