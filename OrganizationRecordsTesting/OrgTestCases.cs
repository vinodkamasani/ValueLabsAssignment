using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValueLabsAssignment.Repoistory;
using ValueLabsAssignment.Services;
using Xunit;

namespace OrganizationRecordsTesting
{
    public class OrgTestCases
    {
       private readonly OrgDetailsService service;
        private readonly Mock<IOrgDetailsRepository> orgDetailRepositoryMock = new Mock<IOrgDetailsRepository>();

        public OrgTestCases()
        {
            service = new OrgDetailsService(orgDetailRepositoryMock.Object);
        }
        [Fact]
        public void Get_Maximum_Quote_Price()
        {
            string[] organizations = new[] { "AAWW", "AAL", "CPAAW", "PRAA", "PAAS", "RYAAY" };
            var expected = "10.209";
            orgDetailRepositoryMock.Setup(x => x.GetMaximumQuotePrice(It.IsAny<List<string>>())).Returns(expected.ToString());
            var actual = service.GetMaximumQuotePrice(organizations.ToList());
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void Get_average_changes_Percentage_for_all_organizations()
        {
            string[] organizations = new[] { "AAWW", "AAL", "CPAAW", "PRAA", "PAAS", "RYAAY" };
            var expected = "10.209";
            orgDetailRepositoryMock.Setup(x => x.AverageQuotesFromAllOrgs(It.IsAny<List<string>>())).Returns(expected.ToString());
            var actual = service.AverageQuotesFromAllOrgs(organizations.ToList());
            Assert.Equal(expected, actual);
        }

    }
}
