using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class HttpClientDemo
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();
        string response = await client.GetStringAsync("https://api.example.com/articles");
        JArray articles = JArray.Parse(response);

        foreach (var article in articles)
        {
            Console.WriteLine($"Title: {article["title"]}");
            Console.WriteLine($"Summary: {article["summary"]}");
        }
    }
}
