﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }


    }
}