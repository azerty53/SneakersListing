using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Sandbox.SneakersListing.Data.Repositories;
using System.IO;

namespace NikeSneakersListing
{
    public class Program
    {
        public static IConfiguration Configuration { get; set; }

        public static AvalaibleSneakersRepository repository;

         static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            repository = new AvalaibleSneakersRepository(Configuration);
        }
    }
}
