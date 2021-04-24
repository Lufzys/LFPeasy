using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Wallet
{
    public class Root
    {
        [JsonProperty("ip")]
        public int Ip { get; set; }

        [JsonProperty("rp")]
        public int Rp { get; set; }
    }
}
