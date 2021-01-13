using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Asyncronous_Tasks
{
    class Program
    {

        const string mainHost = "https://multithreadingtest.azurewebsites.net";

        static void Main(string[] args)
        {

            var token = GetToken("/api/register");

            Console.WriteLine("Your token is: {0}", token);

            var routes = DownloadContentWithToken(token).Result;

            Console.WriteLine("Routes: {0}", String.Join(", ", routes));

            Console.ReadKey();
        }

        public static string GetToken(string suffix)
        {
            return DownloadContent(mainHost + suffix).Result;
        }

        public static async Task<string> DownloadContent(string host)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(host);

                return result;
            }
        }

        public static async Task<List<string>> DownloadContentWithToken(string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string resultAsString = await client.GetStringAsync("https://multithreadingtest.azurewebsites.net/api/routes");

                List<string> result = JsonConvert.DeserializeObject<List<string>>(resultAsString);

                return result;
            }
        }
    }
}
