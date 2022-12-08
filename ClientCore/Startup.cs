using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

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

            if(Environment.IsDevelopment())
            {
                builder.AddDeveloperSigningCredential();
            }

            else
            {
                throw new Exception("Please define your configuration...");
            }
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseIdentityServer();
            }

            app.UseIdentityServer();
        }
    }
}