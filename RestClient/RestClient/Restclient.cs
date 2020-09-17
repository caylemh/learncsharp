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
        //public authenticationType authType { get; set; }
        //public authenticationTechnique authTech { get; set; }
        public string postJSON { get; set; }
        public string putJSON { get; set; }
        public string userEmail { get; set; }
        public string userPswd { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;  
        }

        #region Code for Request Methods
        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();

            // Adding the Autorization Header
            String authHeader = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(userEmail + ":" + userPswd));
            request.Headers.Add("Authorization", "Basic " + authHeader);

            #region --- POST Request Method ---
            if (request.Method == "POST" && postJSON != string.Empty)
            {
                request.Method = "POST";
                request.ContentType = "application/json"; //Really Important
                //request.ContentLength = 10;
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(postJSON);
                    swJSONPayload.Close();
                }
            }
            #endregion

            #region --- PUT Request Method ---
            if (request.Method == "PUT" && putJSON != string.Empty)
            {
                request.Method = "PUT";
                request.ContentType = "application/json"; //Really Important
                //request.ContentLength = 10;
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(postJSON);
                    swJSONPayload.Close();
                }
            }
            #endregion

            #region --- Calling GetResponse ---
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
            #endregion

            return strResponseValue;

        } // End of makeRequest
        #endregion
    } // End of Class
}
