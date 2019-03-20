using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaSat.BusinessLogic
{
    public static class MessageLogic
    {
        public static string Messages1()
        {
            List<string> Messages1 = new List<string>();
            Messages1.Add("Not doing too good, keep trying");
            Messages1.Add("Oh boy, you can do better");
            Messages1.Add("Man, you got a long way to go");
            Random rand = new Random();
            int randMessage = rand.Next(Messages1.Count);
            string randomString = Messages1[randMessage];
            return randomString;
        }
        public static string Messages2()
        {
            List<string> Messages2 = new List<string>();
            Messages2.Add("Not bad, there are some opportunties for improvement");
            Messages2.Add("On the road trying to getting there");
            Messages2.Add("Good things are in store");
            Random rand = new Random();
            int randMessage = rand.Next(Messages2.Count);
            string randomString = Messages2[randMessage];
            return randomString;
        }
        public static string Messages3()
        {
            List<string> Messages3 = new List<string>();
            Messages3.Add("Man oh man, you are making strides");
            Messages3.Add("Keep that momentum going");
            Messages3.Add("Goodbye unknown, hello to almost being famous, not quite, but you're halfway there");
            Random rand = new Random();
            int randMessage = rand.Next(Messages3.Count);
            string randomString = Messages3[randMessage];
            return randomString;
        }
        public static string Messages4()
        {
            List<string> Messages4 = new List<string>();
            Messages4.Add("All Star in the making");
            Messages4.Add("Who doesn't know you, they will soon");
            Messages4.Add("Game changer, game maker");
            Random rand = new Random();
            int randMessage = rand.Next(Messages4.Count);
            string randomString = Messages4[randMessage];
            return randomString;
        }
        public static string Messages5()
        {
            List<string> Messages5 = new List<string>();
            Messages5.Add("Are you a celebrity");
            Messages5.Add("Rockstar MVP");
            Messages5.Add("You need to own Twitter");
            Random rand = new Random();
            int randMessage = rand.Next(Messages5.Count);
            string randomString = Messages5[randMessage];
            return randomString;
        }
    }
}