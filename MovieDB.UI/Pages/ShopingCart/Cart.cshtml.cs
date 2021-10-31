using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataAccess;
using MovieDB.UI.DTOs;
using MovieDB.UI.Models;

namespace MovieDB.UI.Pages.ShopingCart
{
    public class CartModel : PageModel
    {
        private readonly IDataAccess<ProductDTO> _dataAccess;
        //List<Dictionary<int, ProductDTO>> CartProducts;

        public List<CartItem> CartItems { get; set; } = new();
        public CartModel(IDataAccess<ProductDTO> dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void OnGet(Guid id)
        {
            var p = _dataAccess.GetById(id);
            if (p is not null)
            {
                CartItems.Add(new CartItem(p, 1));
            }
        }

        public void OnPost()
        {

        }

        public void AddProduct(ProductDTO p)
        {
            foreach (var item in CartItems)
            {
                if (item.Product.Id == p.Id)
                {
                    item.Quantity = item.Quantity + 1;
                }
                else
                {
                    CartItems.Add(new CartItem(p, 1));
                }
            }
        }

        public void RemoveProduct(ProductDTO p)
        {
            foreach (var item in CartItems)
            {
                if (item.Product.Id == p.Id)
                {
                    CartItems.Remove(item);
                }
            }
        }

        public void DecreaseProductQuantity(ProductDTO p)
        {
            foreach (var item in CartItems)
            {
                if (item.Product.Id == p.Id)
                {
                    item.Quantity = item.Quantity - 1;
                }
            }
        }
    }
}
