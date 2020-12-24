using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueLabsAssignment.Services
{
   public interface IOrgDetailsService
    {
        public string GetMaximumQuotePrice(List<string> organizations);
        public string AverageQuotesFromAllOrgs(List<string> organizations);
    }
}
