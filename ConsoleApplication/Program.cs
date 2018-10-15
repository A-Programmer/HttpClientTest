using System;
using System.Net.Http;

namespace ConsoleApplication
{
    class Program
    {
        //Before
        // public static void Main(string[] args) 
        // {
        //     Console.WriteLine("Starting connections");
        //     for(int i = 0; i<10; i++)
        //     {
        //         using(HttpClient client = new HttpClient())
        //         {
        //             var result = client.GetAsync("https://microsoft.com").Result;
        //             Console.WriteLine(result.StatusCode);
        //         }
        //     }
        //     Console.WriteLine("Connections done");
        // }

        //After
        private static HttpClient Client = new HttpClient();
        public static void Main(string[] args) 
        {
            Console.WriteLine("Starting connections");
            for(int i = 0; i<10; i++)
            {
                var result = Client.GetAsync("https://microsoft.com").Result;
                Console.WriteLine(result.StatusCode);
            }
            Console.WriteLine("Connections done");
        }

        
    }
}
