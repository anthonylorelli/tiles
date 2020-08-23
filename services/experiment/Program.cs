using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using experiment.Utilities;
using System.Net;

namespace experiment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseStartup<Startup>()
                        .ConfigureKestrel((context, options) =>
                            {
                                if (context.HostingEnvironment.IsDevelopment())
                                {
                                    options.Listen(IPAddress.Loopback, 443, listenOptions =>
                                    {
                                        var cert = CertificateUtility.GetBySubject("CN=api.tiles.local");
                                        listenOptions.UseHttps(cert);
                                    });
                                }

                                options.AddServerHeader = false;
                            });
                });
    }
}
