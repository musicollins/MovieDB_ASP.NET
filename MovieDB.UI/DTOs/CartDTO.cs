using System;
using System.Collections.Generic;

namespace MovieDB.UI.DTOs
{
    public class CartDTO
    {
        public Guid Id{ get; set; }
        public List<Dictionary<int, ProductDTO>> Products { get; set; }
    }
}
