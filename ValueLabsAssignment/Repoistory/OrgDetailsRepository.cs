using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueLabsAssignment.Repoistory
{
    public class OrgDetailsRepository : IOrgDetailsRepository
    {
        
        public string GetMaximumQuotePrice(List<string> organizations)
        {
            OrganizationDetails organization = new OrganizationDetails();
            List<OrganizationDetails> organizationDetails = GetOrganizationDetails(organizations);

            organization = organizationDetails.OrderByDescending(x => x.price).FirstOrDefault();
            //avgPercantage = (organizationDetails.Sum(x => x.changesPercentage).Value) / organizationDetails.Count;
            //responseClass.MaxPriceOrganizationDetails = organization;
            //responseClass.AvgChangesPercentage = Math.Round(avgPercantage, 4);
            return organization.price.ToString();
        }

        public string AverageQuotesFromAllOrgs(List<string> organizations)
        {
            OrganizationDetails organization = new OrganizationDetails();
            List<OrganizationDetails> organizationDetails = GetOrganizationDetails(organizations);
            Decimal avgPercantage = (organizationDetails.Sum(x => x.changesPercentage).Value) / organizationDetails.Count;
            return Math.Round(avgPercantage, 4).ToString();
        }

        private List<OrganizationDetails> GetOrganizationDetails(List<string> organizations)
        {
            List<OrganizationDetails> organizationDetails = new List<OrganizationDetails>();
            string url = "/v3/quote/{symbol}?apikey=516d8acff43ea76c313a3e536582d064";
            url = url.Replace("{symbol}", string.Join(",", organizations));
            OrgRestRequest orgRestRequest = new OrgRestRequest();
            String responseStr = orgRestRequest.GetResponseStr(url);
            organizationDetails = JsonConvert.DeserializeObject<List<OrganizationDetails>>(responseStr);
            return organizationDetails;
        }
    }
}
