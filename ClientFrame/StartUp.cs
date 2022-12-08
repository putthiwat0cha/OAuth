using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CliCredent
{
    public class Startup
    {
        public IHostingEnvironment Environment { get; }

        public Startup(IHostingEnvironment env)
        {
            Environment = env;
        }

        public void ConfigureServices(IServiceCollection serv)
        {
            var builder = serv.AddIdentityServer()
                              .AddInMemoryIdentityResources(Config.GetIdens())
                              .AddInMemoryApiResources(Config.GetApis())
                              .AddInMemoryClients(Config.GetClients());

            builder.AddDeveloperSigningCredential();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseIdentityServer();
        }
    }
}