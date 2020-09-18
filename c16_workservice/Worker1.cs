using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace c16_workservice
{
    public class Worker1 : BackgroundService
    {
        private readonly ILogger<Worker1> _logger;

        private HttpClient _client;


        public Worker1(ILogger<Worker1> logger)

        {

            _logger = logger;

        }




        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _client = new HttpClient();
            _logger.LogInformation("The service has been started.");

            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                await _client.GetAsync("https://google.com");

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
