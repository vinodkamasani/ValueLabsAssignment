using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueLabsAssignment
{
    public class OrgRestRequest: RestRequest
    {
        private String baseApiUrl = "https://financialmodelingprep.com/api";
        private OrgRestClient orgRestClient;

        public object RequestBody;

        public string GetResponseStr(string requestUrl,Method httpMethod = Method.GET)
        {
            string responseStr = "";
            string status = "";
            string errMsg = "";

            IRestResponse response = null; ;

            orgRestClient = new OrgRestClient(baseApiUrl);


            RestRequest request = new RestRequest(requestUrl, httpMethod);

            if (RequestBody != null && httpMethod == Method.POST)
                request.AddBody(RequestBody);

            request.RequestFormat = DataFormat.Json;

            try
            {
                response = orgRestClient.Execute(request);
                responseStr = response.Content;
                status = response.StatusDescription;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                responseStr = null;
            }

            if (response != null && response.ErrorException != null)
                throw response.ErrorException;

            return responseStr;
        }
    }
}
