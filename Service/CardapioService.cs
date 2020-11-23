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
            List<MenuModel> listaMenuNaoRepedido = new List<MenuModel>();
            var ICardapioRepository = RestService.For<ICardapiorRepository>(Servico.UrlBaseFoodService());
            var responseListMenu = await ICardapioRepository.GetCardapioPrincipalMenu();
            foreach(MenuModel item in responseListMenu)
            {
                if (!listaMenuNaoRepedido.Any(x => x.titulo == item.titulo))
                    listaMenuNaoRepedido.Add(item);
            }
            return listaMenuNaoRepedido;
        }
        
        public async Task<List<ProdutoModel>> GetListProdutoPorMenu(string codSeqMenu)
        {
            List<int> listCodProduto = new List<int>();
            var ICardapioRepository = RestService.For<ICardapiorRepository>(Servico.UrlBaseFoodService());
            var responseMenu = await ICardapioRepository.GetMenuPorMenuSeq(codSeqMenu);
            foreach(MenuModel item in responseMenu)
            {
                listCodProduto.Add(item.codProduto);
            }
            var responseListProduto = await ICardapioRepository.GetListProdutoPorListProduto(listCodProduto);
            var listaProduto = _iJsonAutoMapper.ConvertAutoMapperListJson<ProdutoModel>(responseListProduto);
            return listaProduto;
        }

    }
}
