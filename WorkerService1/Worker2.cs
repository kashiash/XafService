using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XafService.Module.BusinessObjects;

namespace WorkerService1
{
    public class Worker2: BackgroundService
    {

        private readonly ILogger<Worker2> _logger;

        public Worker2(ILogger<Worker2> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker  2 running at: {time}", DateTimeOffset.Now);

                DataService.InsertData($"Tekst jakis tam {DateTime.UtcNow:hh:mm:ss} by Worker  2 {DateTime.Now:hh:mm:ss}");
                await Task.Delay(13300, stoppingToken);
            }
        }
    }
}
