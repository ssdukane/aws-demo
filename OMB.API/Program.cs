namespace cqrs_3;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
        var LogPath = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
        //NLog.GlobalDiagnosticsContext.Set("LogDirectory", LogPath);
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            }).ConfigureLogging(opt =>
            {
                opt.ClearProviders();
                opt.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
            });
}
