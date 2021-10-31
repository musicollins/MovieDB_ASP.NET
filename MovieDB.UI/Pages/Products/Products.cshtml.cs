using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataAccess;
using MovieDB.UI.DTOs;

namespace MovieDB.UI.Pages.Products
{
    public class ProductsModel : PageModel
    {
        private readonly IDataAccess<ProductDTO> _dataAccess;

        public List<ProductDTO> Products;
        public ProductsModel(IDataAccess<ProductDTO> dataAccess)
        {
            _dataAccess = dataAccess;
            


        }
        public void OnGet()
        {
            Products = _dataAccess.GetAll();
        }
    }
}
