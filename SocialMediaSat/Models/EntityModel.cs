using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SocialMediaSat.Models
{
    public class EntityModel
    {
        [JsonProperty("hashtags")]
        public List<HashtagModel> Hashtags { get; set; }

        public string HashTagsDisplay
        {
            get
            {
                string display = "";
                foreach (var hashtag in Hashtags)
                {
                    display += hashtag.Text + Environment.NewLine;
                }

                return display;
            }
            set { HashTagsDisplay = value; }
        }
    }
}