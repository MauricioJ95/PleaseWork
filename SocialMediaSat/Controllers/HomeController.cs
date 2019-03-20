using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SocialMediaSat.BusinessLogic;
using SocialMediaSat.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SocialMediaSat.Controllers
{
    public class HomeController : Controller
    {
        //declare a Twitter object to use inside of actionresults - gives auth 
        public Twitter twitter = new Twitter
        {
            OAuthConsumerKey = ConfigurationManager.AppSettings["OAuthConsumerKey"],
            OAuthConsumerSecret = ConfigurationManager.AppSettings["OAuthConsumerSecret"]
        };
        
        //taking user input
        public ActionResult Index()
        {
            return View();
        }

        //Method to take (text) from the user input and generate a list - display list in our view bag
        [HttpPost]
        public ActionResult Create(string text)
        {
            int count = 10;
            var result = twitter.GetSpecificUserPost(text, count).Result;
            List<TwitObject> TweeitsList = MapResultToTweetList(result);
            var model = new TweetListModel
            {
                TweetsList = TweeitsList
            };

            Session["TweetObject"] = model;
            return View("TweetsList", model);
        }

        [HttpGet]
        public ActionResult Messages(string Likes, string Retweets, string Tweet)
        {
            var TweetModel = Session["TweetObject"] as TweetListModel;
            int likes = int.Parse(Likes);
            int retweets = int.Parse(Retweets);
            if (likes <= 100 && likes > 0 || retweets <= 50 && retweets > 0)
            {
                string tempMessage = MessageLogic.Messages1();
                ViewBag.Like = tempMessage;
            }
            else if (likes > 100 && likes < 250 || retweets <= 125 && retweets > 50)
            {
                string tempMessage = MessageLogic.Messages2();
                ViewBag.Like = tempMessage;
            }
            else if (likes > 250 && likes < 750 || retweets <= 375 && retweets > 125)
            {
                string tempMessage = MessageLogic.Messages3();
                ViewBag.Like = tempMessage;
            }
            else if (likes > 750 && likes < 1000 || retweets <= 500 && retweets > 375)
            {
                string tempMessage = MessageLogic.Messages4();
                ViewBag.Like = tempMessage;
            }
            else if (likes > 1000 || retweets > 500)
            {
                string tempMessage = MessageLogic.Messages5();
                ViewBag.Like = tempMessage;
            }
            ViewBag.Tweet = Tweet;
            return View("TweetsList", TweetModel);
        }

        private List<TwitObject> MapResultToTweetList(string result)
        {
            return JsonConvert.DeserializeObject<List<TwitObject>>(result);
        }

        public ActionResult TweetsList(List<TwitObject>TweetsList)
        {

            ViewBag.tweetsList = TweetsList;
            return View();
        }

        private TrendList MapResultToTrendList(string result)
        {
            return JsonConvert.DeserializeObject<TrendList>(result);
        }

        [HttpGet]
        public ActionResult Trends(List<TrendList> Trends)
        {
            var result = twitter.GetListOfTrends("Detroit", 10).Result;
            var obj = JArray.Parse(result);
            var strResults = obj[0].ToString();
            var model = MapResultToTrendList(strResults);
            
            return View(model);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Social Media Satillite";

            return View();
        }

        public ActionResult Analytics()
        {
            ViewBag.Message = "Analytics page!! what up!";

            return View();
        }
    }
}