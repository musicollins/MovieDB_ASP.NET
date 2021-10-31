using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.UI.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductType ProductType { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }

    public enum ProductType
    {
        PHYSICAL,
        DIGITAL
    }
}
