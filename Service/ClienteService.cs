using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UxFoodService.Model;
using UxFoodService.Service.Interface;

namespace UxFoodService.Service
{
    public class ClienteService : IClienteService
    {

        public async Task<ClienteModel> ObterCliente()
        {
            var IClienteRepository = RestService.For<IClienteRepository>(Servico.UrlBaseFoodService());
            var clienteModel = await IClienteRepository.ObterCliente("manoelcontatosi@gmail.com");
            return clienteModel;
        }
    }
}
