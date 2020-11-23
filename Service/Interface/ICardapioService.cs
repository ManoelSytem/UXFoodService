using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UxFoodService.Model;

namespace UxFoodService.Service.Interface
{
    public interface ICardapioService
    {
        public Task<List<MenuModel>> GetListMenu();
        public Task<List<ProdutoModel>> GetListProdutoPorMenu(string codSeqMenu);
        
    }
}
