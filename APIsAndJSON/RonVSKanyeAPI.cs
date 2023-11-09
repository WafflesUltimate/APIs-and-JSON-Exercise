using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public string GetKanyeQuote()
        {
            HttpClient kanyeClient = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = kanyeClient.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string GetRonQuote()
        {
            HttpClient ronClient = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = ronClient.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();

            return ronQuote;
        }

    }
}
