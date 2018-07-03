using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        private static HttpClient s_httpClient;
        static async Task Main(string[] args)
        {
            await CallGetAsync2();
        }

        private static async Task CallGetAsync()
        {
            using (var client = new HttpClient())  // don't use HttpClient this way!!!
            {
                HttpResponseMessage resp = await client.GetAsync("https://www.cninnovation.com/downloads/Racers.xml");
                resp.EnsureSuccessStatusCode();
                string data = await resp.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }

        }

        private static async Task CallGetAsync2()
        {
            if (s_httpClient == null)
            {
                s_httpClient = new HttpClient();
            }
            HttpResponseMessage resp = await s_httpClient.GetAsync("https://www.cninnovation.com/downloads/Racers.xml");
            resp.EnsureSuccessStatusCode();
            string data = await resp.Content.ReadAsStringAsync();  // LOH???
            Console.WriteLine(data);


        }
    }
}
