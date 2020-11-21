using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UxFoodService.Model;
using UxFoodService.Service.Interface;
using UxFoodService.Util;

namespace UxFoodService.Service
{
    public class CardapioService : ICardapioService
    {
        private readonly IJsonAutoMapper _iJsonAutoMapper;
        public CardapioService(IJsonAutoMapper _IJsonAutoMapper)
        {
            _iJsonAutoMapper = _IJsonAutoMapper;
        }

        public async Task<List<MenuModel>> GetListMenu()
        {
            var ICardapioRepository = RestService.For<ICardapiorRepository>(Servico.UrlBaseFoodService());
            var responseListMenu = await ICardapioRepository.GetListMenuCardapioPorId(18);
            var listaMenu = _iJsonAutoMapper.ConvertAutoMapperListJson<MenuModel>(responseListMenu);
            return listaMenu;
        }

        public async Task<List<ProdutoModel>> GetListProdutoPorMenu(List<int> listadeProduto)
        {
            var ICardapioRepository = RestService.For<ICardapiorRepository>(Servico.UrlBaseFoodService());
            var responseListProduto = await ICardapioRepository.GetListProdutoPorListProduto(listadeProduto);
            var listaMenu = _iJsonAutoMapper.ConvertAutoMapperListJson<ProdutoModel>(responseListProduto);
            return listaMenu;
        }

    }
}
