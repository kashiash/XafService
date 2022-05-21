using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XafService.Module.BusinessObjects;

namespace WorkerService1
{
    public class MyCronJob2 : CronJobService
    {
        private readonly ILogger<MyCronJob2> _logger;

        public MyCronJob2(IScheduleConfig<MyCronJob2> config, ILogger<MyCronJob2> logger)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob 2 starts.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} CronJob 2 is working.");

            DataService.InsertData($"Tekst jakis tam {DateTime.UtcNow.ToString()} by Cron 2");

            return Task.CompletedTask;
        }



        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob 2 is stopping.");
            return base.StopAsync(cancellationToken);
        }
    }
}
