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

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

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
            catch(Exception ex)
            {
                strResponseValue = "{\"errorMessages\":{\"" + ex.Message.ToString() + "\"}, \"errors\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }               
            }

            return strResponseValue;
        }
    }
}
