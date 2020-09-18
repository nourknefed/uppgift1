using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace WorkerService_uppgift1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        public Random Num;
        //private string url = "https://api.openweathermap.org/data/2.5/onecall?lat=59.27412&lon=15.2066&exclude=current-daily-hourly&appid=bea7b0cf12273cc11febf06fd50ac80f";
        //private HttpClient client;
       // private HttpResponseMessage result;
      
     

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

       


        public override Task StartAsync(CancellationToken cancellationToken)
        {
            //client = new HttpClient();
            _logger.LogInformation("The service has been started.");

            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The service has been stopped.");
            return base.StopAsync(cancellationToken);
        }
        //public static async Task<dynamic> Makeresult (string url)
        //{
        //    var client = new HttpClient();

        //    var result = await client.GetAsync(url);

        //    dynamic json = JsonConvert.DeserializeObject($"{ result}");
        //    return json;
        //}

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //dynamic response = await Worker.Makeresult("https://api.openweathermap.org/data/2.5/onecall?lat=59.27412&lon=15.2066&exclude=current-daily-hourly&appid=bea7b0cf12273cc11febf06fd50ac80f");
                //Console.WriteLine(response);

             
                
                try
                {
                    Random Num = new Random();
                    int rNum;
                    rNum = Num.Next(18, 50);



                    if (rNum > 30)
                    {
                        Console.WriteLine($"The tempreture now is {rNum} . It´s too hot.");
                    }
                    else
                    {
                        Console.WriteLine($"The tempreture now is {rNum} . It´s a nice day");
                    }

                }
                catch(Exception ex)
                {
                    _logger.LogInformation($"{ex.Message}");
                }
               


                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
