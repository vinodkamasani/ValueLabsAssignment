using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValueLabsAssignment.Repoistory;

namespace ValueLabsAssignment.Services
{
    public class OrgDetailsService : IOrgDetailsService
    {
        private readonly IOrgDetailsRepository orgDetailsRepository;
        public OrgDetailsService(IOrgDetailsRepository orgDetailsRepository)
        {
            this.orgDetailsRepository = orgDetailsRepository;
        }

        public string AverageQuotesFromAllOrgs(List<string> organizations)
        {
            return orgDetailsRepository.AverageQuotesFromAllOrgs(organizations);
        }

        public string GetMaximumQuotePrice(List<string> organizations)
        {
            String x =orgDetailsRepository.GetMaximumQuotePrice(organizations);
            return x;
        }
    }
}
