using System;
using System.IO;
using System.Net;
using System.Text;

namespace RestClient
{
    public enum httpverb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public httpverb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpverb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error Code: " + response.StatusCode.ToString());
                }
                // Process the response stream... (could be JSON, XML or HTML, etc...)

            using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader =  new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }// End of StreamReader
                    }
                } // End of using ResponseStream

            }// End of using response


            return strResponseValue;
        }
    }
}
