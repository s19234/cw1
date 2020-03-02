using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(String[] args)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(args[0]);
        }
    }
}
