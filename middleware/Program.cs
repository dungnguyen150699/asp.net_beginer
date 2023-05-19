using _02.middleware;

namespace middleware
{
    class Program
    {
        /*
        Host {IHost} object:
        - Dependency inject (ID) : IServiceProvider (ServiceCollection)
        - Logging (ILogging)
        - Configuration
        - IHostedService => StartAsync: run Http Server (kestrel http)
        
        1) Tao IHostBuilder
        2) Cau hinh, dang ky cac dich vu ( goi configuraWebHostdefaults)
        3) IHostBuilder.Build() => Host ( IHost )
        4) Host.run();
        */

        public static void Main(string[] args)
        {
            Console.WriteLine("Start app");
            IHostBuilder builder = Host.CreateDefaultBuilder();
            builder.ConfigureWebHostDefaults((IWebHostBuilder webHostBuilder) =>
            {
                // Tuy bien them ve host
                // web builder
                webHostBuilder.UseStartup<Startup>();
            });
            IHost host = builder.Build();
            host.Run();
        }
    }
}