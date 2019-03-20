using Newtonsoft.Json;
using System.Collections.Generic;

namespace SocialMediaSat.Models
{
    public class TrendList
    {
        [JsonProperty("trends")]
        public List<TrendModel> Trends { get; set; }
    }
}