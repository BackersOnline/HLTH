using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace HKTH
{
    class Program
    {
        static void Main(string[] args)
        {
            //  RedoxPatientSearch();
            string json = FitBitGetActivity();
            var activities = JsonConvert.DeserializeObject<RootObject>(json);
            List<Activity> lstActivity = activities.activities;

            RedoxPostFitBitActivity();

        }

        static void RedoxPatientSearch()
        {
            var baseAddress = "https://api.redoxengine.com/query";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Headers.Add("Authorization", "Bearer db0f85e7-a309-4aef-9bfa-22ff760552ae");

            http.Method = "POST";

            string content = string.Empty;
            using (StreamReader r = new StreamReader(@"C:\Users\yksok_000\Documents\Welness\RedoxPatientSearch.json"))
            {
                content = r.ReadToEnd();
            }

            
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(content);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var contentResponse = sr.ReadToEnd();
        }

        static void RedoxPostFitBitActivity()
        {
            var baseAddress = "https://api.redoxengine.com/endpoint";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Headers.Add("Authorization", "Bearer db0f85e7-a309-4aef-9bfa-22ff760552ae");

            http.Method = "POST";

            string content = string.Empty;
                //FitBitGetActivity();
            using (StreamReader r = new StreamReader(@"C:\Users\yksok_000\Documents\Welness\fitbittoredoxsample1.json"))
            {
                content = r.ReadToEnd();
            }


            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(content);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var contentResponse = sr.ReadToEnd();
        }

        static string FitBitGetActivity()
        {
            string strResponse = String.Empty;
            string accessToken = "eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiI2SzI2UlMiLCJhdWQiOiIyMkNXUVoiLCJpc3MiOiJGaXRiaXQiLCJ0eXAiOiJhY2Nlc3NfdG9rZW4iLCJzY29wZXMiOiJ3aHIgd3BybyB3bnV0IHdzbGUgd3dlaSB3c29jIHdzZXQgd2FjdCB3bG9jIiwiZXhwIjoxNTI2MTYxNDQ1LCJpYXQiOjE1MjU1NTY3MzV9.MPx_N9HpLbm2H7yAjGtOzMTwXrs15_P_HXDi9fq8eO8";
            string url = "https://api.fitbit.com/1/user/6K26RS/activities/date/2018-04-07.json";
            var cli = new WebClient();
            cli.Headers.Add("Authorization", $"Bearer {accessToken}");
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            strResponse = cli.DownloadString(url);

            return strResponse;
        }
    }
}
