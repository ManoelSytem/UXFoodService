using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using UxFoodService.Service.Interface;
using UxFoodService.Service;
using Refit;
using UxFoodService.Util;
using Blazored.LocalStorage;

namespace UxFoodService
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<IJsonAutoMapper, JsonAutoMapperGeneric>();
            builder.Services.AddSingleton<ICardapioService, CardapioService>();
            builder.Services.AddSingleton<IMesaService, MesaService>();
            builder.Services.AddSingleton<IClienteService, ClienteService>();
            builder.Services.AddBlazoredLocalStorage();
            await builder.Build().RunAsync();
        }
    }
}
