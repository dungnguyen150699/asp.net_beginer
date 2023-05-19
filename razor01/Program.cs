using config_startup;

namespace razor01
{
    class Program
    {
        static void Main(string[] args)
        {
            IHostBuilder builder = new HostBuilder();
            builder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

            IHost host = builder.Build();
            host.Run();
        }
    }
}