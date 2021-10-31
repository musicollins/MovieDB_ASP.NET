using MovieDB.UI.DataSource;
using MovieDB.UI.DTOs;
using MovieDB.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.UI.DataAccess
{
    public class ProductsDataAccess : IDataAccess<ProductDTO>
    {
        private readonly DataSource_Json _dataSource;

        public List<ProductDTO> Products { get; set; }
        public ProductsDataAccess(DataSource_Json dataSource)
        {
            _dataSource = dataSource;

            var jsonResponse = _dataSource.DataProviderProducts();
            Products = JsonConvert.DeserializeObject<List<ProductDTO>>(jsonResponse);
        }
        public List<ProductDTO> GetAll()
        {
            return Products;
        }

        public ProductDTO GetById(Guid id)
        {
            var productDto = Products.SingleOrDefault(p => p.Id == id);
            if (productDto is not null)
            {
                return productDto;
            }
            else
            {
                return null;
            }
        }


    }
}
