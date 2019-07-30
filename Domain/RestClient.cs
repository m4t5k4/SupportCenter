using System;
using System.IO;
using System.Net;

namespace SC.BL.Domain
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class RestClient
    {
        public string EndPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string jsonTxt { get; set; }


        public RestClient()
        {
        }

        public string GetRequest()
        {
            httpMethod = httpVerb.GET;
            string strResponseValue = "";
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(EndPoint);
            req.Method = httpMethod.ToString();
            using (HttpWebResponse resp = (HttpWebResponse) req.GetResponse())
            {
                if (resp.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("fout: " + resp.StatusCode);
                }

                using (Stream responseStream = resp.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return strResponseValue;
        }

        public void PostRequest(string nr, string device, string problem)
        {
            jsonTxt = "{\"id\": " +
                      nr +
                      ",\"device\": " +
                      device +
                      ",\"problem\": " +
                      problem +
                      "}";
            EndPoint = "http://localhost:3000/tickets";
            httpMethod = httpVerb.POST;
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(EndPoint);
            req.Method = httpMethod.ToString();
            req.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(req.GetRequestStream()))
            {
                sw.Write(jsonTxt);
                sw.Close();
            }
        }
    }
}