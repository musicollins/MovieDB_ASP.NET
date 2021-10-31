using MovieDB.UI.DTOs;

namespace MovieDB.UI.Models
{
    public class CartItem
    {
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(ProductDTO product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        //public void InserProduct(ProductDTO p, int q)
        //{
        //    Product = p;
        //    Quantity = q;
        //}
    }
}
