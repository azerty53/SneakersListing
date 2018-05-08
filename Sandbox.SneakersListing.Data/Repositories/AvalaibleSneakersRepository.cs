using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.SneakersListing.Data.Repositories
{
    public class AvalaibleSneakersRepository
    {
        string _url;

        public AvalaibleSneakersRepository(IConfiguration config)
        {
            _url = config.GetConnectionString("Api");
            Console.WriteLine(_url);
            Console.ReadLine();
        }


    }
}
