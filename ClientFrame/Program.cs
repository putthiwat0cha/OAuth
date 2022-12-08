// Net Framework <4.8>
// Microsoft.Extensions.Configuration.Abstractions <2.1.0>

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CliCredent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostServer(args).UseKestrel()
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseUrls("http://localhost:63554")
                            .UseIISIntegration()
                            .UseStartup<Startup>()
                            .Build()
                            .Run();
        }

        public static IWebHostBuilder HostServer(string[] args)
        => WebHost.CreateDefaultBuilder(args);
    }
}