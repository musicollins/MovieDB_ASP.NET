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
    public class ProductModel : PageModel
    {
        private readonly IDataAccess<ProductDTO> _dataAccess;

        public ProductDTO Product;
        public ProductModel(IDataAccess<ProductDTO> dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void OnGet(Guid id)
        {
            Product = _dataAccess.GetById(id);
        }
    }
}
