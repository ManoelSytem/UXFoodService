using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UxFoodService.Model;
using UxFoodService.Service.Interface;
using UxFoodService.Util;

namespace UxFoodService.Service
{
    public class MesaService : IMesaService
    {
        private readonly IJsonAutoMapper _iJsonAutoMapper;
        public MesaService(IJsonAutoMapper _IJsonAutoMapper)
        {
            _iJsonAutoMapper = _IJsonAutoMapper;
        }

        public async Task<List<MesaModel>> GetListMesa()
        {
            var IMesaRepository = RestService.For<IMesaRepository>(Servico.UrlBaseFoodService());
            var listaMesa = await IMesaRepository.ObterListaMesa();
            return listaMesa;
        }
    }
}
