using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reddit.AuthTokenRetriever;
using Reddit.AuthTokenRetriever.EventArgs;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace Reddit2Video
{
    class Program
    {
        static void Main(string[] args)
        {
            RedditHelper redditHelper = new RedditHelper();
            var asd = redditHelper.GetSubRedditTopPostsBody("tifu", 5);
            
        }

      
    }
}
