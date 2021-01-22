using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = DownloadContent().Result;
            var routes = DownloadContentWithToken(token, "/api/routes").Result;

            GetKeywordsTaskWhenAnyFinished(token, routes);
            GetKeywordsTaskWhenAllFinished(token, routes);
        }

        public static async Task GetKeywordsTaskWhenAllFinished(string token, List<string> routes)
        {
            List<Task<List<string>>> subroutesTasks = new List<Task<List<string>>>();
            List<Task<string>> keywordsTasks = new List<Task<string>>();

            foreach (string route in routes)
            {
                subroutesTasks.Add(DownloadContentWithToken(token, route));
                Console.WriteLine(route);
            }

            var subroutes = Task.WhenAll(subroutesTasks);

            foreach (List<string> keywordRoute in subroutes.Result)
            {
                foreach (string keyword in keywordRoute)
                {
                    keywordsTasks.Add(GetKeyword(token, keyword));
                    Console.WriteLine(keyword);
                }
            }
            var keywords = Task.WhenAll(keywordsTasks).Result;

            foreach (string keyword in keywords)
                Console.WriteLine( keyword);

        }

        public static async Task GetKeywordsTaskWhenAnyFinished(string token, List<string> routes)
        {
            List<Task<List<string>>> subroutes = new List<Task<List<string>>>();
            List<Task<string>> keywords = new List<Task<string>>();

            foreach (string route in routes)
            {
                subroutes.Add(DownloadContentWithToken(token, route));
                Console.WriteLine(route);
            }

            while (subroutes.Count > 0)
            {
                var subroute = Task.WhenAny(subroutes).Result;
                foreach (string keywordRoute in subroute.Result)
                {
                    keywords.Add(GetKeyword(token, keywordRoute));
                    Console.WriteLine(keywordRoute);
                }
                subroutes.Remove(subroute);
            }

            while (keywords.Count > 0)
            {
                var keyword = Task.WhenAny(keywords).Result;
                Console.WriteLine(keyword.Result);
                keywords.Remove(keyword);
            }
        }
        public static async Task<string> GetKeyword(string token, string route)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string resultAsString = await client.GetStringAsync("https://multithreadingtest.azurewebsites.net" + route);

                return resultAsString;
            }
        }
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("https://multithreadingtest.azurewebsites.net/api/register");

                return result;
            }
        }
        public static async Task<List<string>> DownloadContentWithToken(string token, string route)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string resultAsString = await client.GetStringAsync("https://multithreadingtest.azurewebsites.net" + route);
                List<string> result = JsonSerializer.Deserialize<List<string>>(resultAsString);

                return result;
            }
        }
    }
}
