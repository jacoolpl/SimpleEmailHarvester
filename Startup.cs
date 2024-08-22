using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace SimpleEmailHarvester
{
    // Inside the Startup.cs class
    public class Startup
    {
        //public IConfiguration Configuration { get; }

        //public Startup(IConfiguration configuration)
        //{
        //    var build = new ConfigurationBuilder();
        //    build.AddConfiguration(configuration);
        //    //build.Sources.Add("appsettings.json");

        //    ////.SetBasePath(Directory.GetCurrentDirectory());  // 获取当前程序执行目录
        //    //build.AddJsonFile(CONFIG_FILE, true, true);
        //    //Configs = build.Build();


        //    //var builder = new ConfigurationBuilder()
        //    //    .AddEnvironmentVariables()
        //    //.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);


        //    Configuration = configuration;
        //}

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    // Access settings from appsettings.json
        //    var ApiKey = Configuration["AppConfig:ApiKey"];
        //    var searchEngineId = Configuration["AppConfig:searchEngineId"];
        //    //var connectionString = Configuration.GetConnectionString("DefaultConnection");

        //    // Other service configurations...
        //}
    }
}
