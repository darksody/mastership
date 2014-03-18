using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ub = new UriBuilder("http://www.w3schools.com");
            ub.Query = "test=123";
            
            var tst = ub.ToString();



            UriBuilder bannerUrlBuilder = new UriBuilder("http://www.w3schools.com");

            var bannerParams = new Dictionary<string,string>();

            bannerParams.Add("LastDepositAmount", "val1");
            bannerParams.Add("LastDepositCurrency", "val2");
            bannerParams.Add("LastPaymentMethod", "val3");

            bannerUrlBuilder.Query = string.Join("&", bannerParams.Keys.Where(key => !string.IsNullOrWhiteSpace(bannerParams[key])).Select(key => string.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(bannerParams[key]))));
            //TO-DO: set iFrame's source and make it visible, hide the gif banner
            var bannerUrl = bannerUrlBuilder.ToString();
        }
    }
}
