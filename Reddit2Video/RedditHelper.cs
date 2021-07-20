using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reddit2Video
{
    class RedditHelper
    {
        public string token { get; set; }

        public RedditHelper()
        {
            var authClient = new RestClient("https://www.reddit.com/api/v1/access_token");
            var authRequest = new RestRequest(Method.POST);
            authRequest.AddHeader("User-Agent", "MyAPI/0.0.1");
            authRequest.AddHeader("Authorization", "Basic " + System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                               .GetBytes(Credentials.Default.RedditClientID + ":" + Credentials.Default.RedditSecret)));
            authRequest.AddParameter("application/x-www-form-urlencoded", $"grant_type=password&username={Credentials.Default.RedditUsername}&password={Credentials.Default.RedditPassword}", ParameterType.RequestBody);
            IRestResponse response = authClient.Execute(authRequest);

            if (response.StatusCode != HttpStatusCode.OK) return;
            dynamic responseContent = JObject.Parse(response.Content);
            string authToken = responseContent.access_token;
            authToken = authToken.Replace("{", "").Replace("}", "");

            if (!String.IsNullOrEmpty(authToken)) token = authToken;
            else
            {
                throw new Exception("Exeption during authentication");
            }
        }

        public List<string> GetSubRedditTopPostsBody(string subRedditName, int howMany)
        {
            var client = new RestClient($"https://oauth.reddit.com/r/{subRedditName}/hot");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {token}");
            IRestResponse response = client.Execute(request);

            dynamic data = JObject.Parse(response.Content);

            List<string> result = new List<string>();
            //foreach (var post in data.data.children)
            //{
            //    string postBody = post.data.selftext;
            //    result.Add(postBody);
            //}

            JArray posts = data.data.children;
            if (posts.Count < howMany - 1) howMany = posts.Count + 1;

            for (int i = 0; i < howMany; i++)
            {

                string postBody = data.data.children[i].data.selftext;
                result.Add(postBody);
            }

            return result;
        }
    }
}
