using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueLabsAssignment.Repoistory
{
   public interface IOrgDetailsRepository
    {
        public string GetMaximumQuotePrice(List<string> organizations);
        public string AverageQuotesFromAllOrgs(List<string> organizations);
    }
}
