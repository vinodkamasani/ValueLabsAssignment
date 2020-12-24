using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueLabsAssignment
{
    public class OrgRestClient: RestClient
    {
        public OrgRestClient(string baseUrl)
        {
            base.BaseUrl = new Uri(baseUrl);
        }

        // Execute the Rest API request with given headers and authorization information.
        public override IRestResponse Execute(IRestRequest request)
        {
            //Log the request
            //#TODO: Logging the request

            IRestResponse restObject = base.Execute(request);
            //#TODO: Log the response respObject
            //#TODO: Logging the request

            return restObject;
        }
    }
}
