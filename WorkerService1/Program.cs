using WorkerService1;


IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<Worker2>();
        services.AddCronJob<MyCronJob2>(c =>
        {
            c.TimeZoneInfo = TimeZoneInfo.Local;
            c.CronExpression = @"*/3 * * * *";
        });
        services.AddCronJob<MyCronJob3>(c =>
        {
            c.TimeZoneInfo = TimeZoneInfo.Local;
            c.CronExpression = @"*/4 * * * *";
        });
    })


    .UseWindowsService()
    .Build();

await host.RunAsync();
