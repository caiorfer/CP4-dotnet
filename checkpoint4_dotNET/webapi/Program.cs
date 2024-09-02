public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                      .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                var configuration = context.Configuration;

               
                services.AddHttpClient<ExchangeRateService>(client =>
                {
                    client.BaseAddress = new Url(configuration["ApiSettings:https://v6.exchangerate-api.com/v6/feb628771760a04e158f0340/latest/USD"]);
                });

                services.AddControllers();
            });
}