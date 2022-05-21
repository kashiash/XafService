using DevExpress.Xpo;
using XafService.Module.BusinessObjects;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);



                DataService.InsertData($"Tekst jakis tam {DateTime.UtcNow:hh:mm:ss} by Workier 1 {DateTime.Now:hh:mm:ss}");

                await Task.Delay(12000, stoppingToken);
            }
        }
    }
}