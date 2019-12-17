using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyLibrary.Data;

namespace MyLibrary
{
    public class Program
    {


        public static void Main(string[] args)
        {
            InsertData();
            CreateWebHostBuilder(args).Build().Run();
        }

        private static void InsertData()
        {
            using(var context = new LibraryContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
            }
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
