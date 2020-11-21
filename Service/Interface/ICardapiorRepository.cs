﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UxFoodService.Model;

namespace UxFoodService.Service.Interface
{
    public interface ICardapiorRepository
    {
        [Get("/Cardapio/GetListMenuCardapioPorId")]
        Task<List<MenuModel>> GetListMenuCardapioPorId(int IdCardapio);
        [Post("/Produto/GetListProdutoPorListaProduto")]
        Task<List<ProdutoModel>> GetListProdutoPorListProduto(List<int> listProduto);
    }
}
