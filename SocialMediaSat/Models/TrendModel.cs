using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaSat.Models
{
    public class TrendModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("promoted_content")]
        public string PromotedContent { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("tweet_volume")]
        public string TweetVolume { get; set; }
    }
}