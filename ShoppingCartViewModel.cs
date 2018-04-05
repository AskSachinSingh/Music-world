using System;
using System.Collections.Generic;
using MusicWorld.Models;

namespace MusicWorld.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}