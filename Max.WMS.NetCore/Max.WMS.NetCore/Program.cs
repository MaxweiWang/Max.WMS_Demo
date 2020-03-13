using Max.Core.Utils.Configs;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System.Text;

namespace Max.WMS.NetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args)
        {
            var config = ConfigUtil.GetConfiguration;
            if (string.IsNullOrWhiteSpace(config["urls"]))
            {
                return Host.CreateDefaultBuilder(args)
             .ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseStartup<Startup>();
             });
                //.ConfigureLogging(logging =>
                //{
                //    logging.ClearProviders();
                //    logging.SetMinimumLevel(LogLevel.None);
                //})
                //  .UseNLog();
            }
            else
            {
                return Host.CreateDefaultBuilder(args)
                           .ConfigureWebHostDefaults(webBuilder =>
                           {
                               webBuilder.UseConfiguration(ConfigUtil.GetConfiguration);
                               webBuilder.UseStartup<Startup>();
                           });
                //.ConfigureLogging(logging =>
                //{
                //    logging.ClearProviders();
                //    logging.SetMinimumLevel(LogLevel.None);
                //})
                //.UseNLog();
            }
        }
    }
}