// Net Core <5.0>
// Microsoft.Extensions.Configuration.Abstractions <2.1.0>

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CliCredent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostServer(args).Build()
                            .Run();
        }

        public static IWebHostBuilder HostServer(string[] args)
        => WebHost.CreateDefaultBuilder(args)
                  .UseStartup<Startup>();
    }
}