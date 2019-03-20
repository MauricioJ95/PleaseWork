using Newtonsoft.Json;
using SocialMediaSat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SocialMediaSat
{
    public class TwitObject
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("favorite_count")]
        public string Likes { get; set; }
        [JsonProperty("retweet_count")]
        public string Retweets { get; set; }
        [JsonProperty("entities")]
        public EntityModel Entities { get; set; }
        public TwitObject(string text, string likes)
        {
            this.Text = text;
            this.Likes = likes;
            this.Retweets = "0";
        }
        public TwitObject(string text, string likes, string retweets, string url)
        {
            this.Text = text;
            this.Likes = likes;
            this.Retweets = retweets;
        }
        public TwitObject(string text, string likes, string retweets)
        {
            this.Text = text;
            this.Likes = likes;
            this.Retweets = retweets;
        }
        public TwitObject(string text, string likes, string retweets, List<string> hastags, string url)
        {
            this.Text = text;
            this.Likes = likes;
            this.Retweets = retweets;
        }
        public TwitObject(string text, string likes, string retweets, List<string> hastags)
        {
            this.Text = text;
            this.Likes = likes;
            this.Retweets = retweets;
        }
        public TwitObject()
        {
            this.Text = "***Something Went Wrong***";
            this.Likes = "-1";
        }
        override public string ToString()
        {
            return ("Twitter Post: " + Text + System.Environment.NewLine +
                "Amount of Likes: " + Likes + System.Environment.NewLine);
        }
    }
}