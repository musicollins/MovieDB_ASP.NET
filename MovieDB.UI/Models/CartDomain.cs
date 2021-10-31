using MovieDB.UI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.UI.Models
{
    public class CartDomain
    {

        List<CartItem> CartItems { get; set; }

        public CartDomain()
        {
            CartItems = new List<CartItem>();
        }

        


    }
}
