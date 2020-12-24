using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueLabsAssignment
{
    public class ListOfOrganizations
    {
        public OrganizationDetails[] Results { get; set; }
    }
    public class OrganizationDetails
    {
        [JsonProperty("symbol")]
        public string symbol { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("price")]
        public decimal price { get; set; }
        [JsonProperty("changesPercentage")]
        public decimal? changesPercentage { get; set; }
        [JsonProperty("change")]
        public decimal? change { get; set; }
        [JsonProperty("dayLow")]
        public decimal? dayLow { get; set; }
        [JsonProperty("dayHigh")]
        public decimal? dayHigh { get; set; }
        [JsonProperty("yearHigh")]
        public decimal? yearHigh { get; set; }
        [JsonProperty("yearLow")]
        public decimal? yearLow { get; set; }
        [JsonProperty("marketCap")]
        public decimal? marketCap { get; set; }
        [JsonProperty("priceAvg50")]
        public decimal? priceAvg50 { get; set; }
        [JsonProperty("priceAvg200")]
        public decimal? priceAvg200 { get; set; }
        [JsonProperty("volume")]
        public long? volume { get; set; }
        [JsonProperty("avgVolume")]
        public long? avgVolume { get; set; }
        [JsonProperty("exchange")]
        public string exchange { get; set; }
        [JsonProperty("open")]

        public decimal? open { get; set; }
        [JsonProperty("previousClose")]
        public decimal? previousClose { get; set; }
        [JsonProperty("eps")]
        public decimal? eps { get; set; }
        [JsonProperty("pe")]
        public long? pe { get; set; }
        [JsonProperty("earningsAnnouncement")]
        public DateTime? earningsAnnouncement { get; set; }
        [JsonProperty("sharesOutstanding")]
        public long? sharesOutstanding { get; set; }
        [JsonProperty("timestamp")]
        public long? timestamp { get; set; }

    }
}
