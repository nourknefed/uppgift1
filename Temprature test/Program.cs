using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Temprature_test
{
    class Program
    {
        private static HttpClient client;
        static void Main(string[] args)
        {
            Console.ReadLine();
            Getdata().GetAwaiter();
            Console.ReadKey();
        }



        public static async Task Getdata()
        {
             client = new HttpClient();

            var response = await client.GetAsync("https://api.openweathermap.org/data/2.5/onecall?lat=59.27412&lon=15.2066&exclude=current-daily-hourly&appid=bea7b0cf12273cc11febf06fd50ac80f");
            var result = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<dynamic>(result);

            Console.WriteLine(data);
        }

        
    }
}
