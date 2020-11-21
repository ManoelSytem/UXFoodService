﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UxFoodService.Service
{
    public class Servico
    {
        public Servico()
        {
          
        }

        public static string UrlBase()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile($"appsettings.json");
            var config = builder.Build();

            string urlBase = config.GetSection("APIServAutenticacao:UrlBase").Value;
            return urlBase;
        }

        public static string UrlBaseFoodService()
        {
            string urlBase = "https://localhost:5003/api";
            return urlBase;
        }
    }
}
