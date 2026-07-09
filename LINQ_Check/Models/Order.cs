using LINQ_Check.Delivery;
using LINQ_Check.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Models
{
    public sealed class Order
    {


        public required ProductDto Product { get; init; }
        public required IDiscountStrategy Discount { get; init; }
        public required IShippingMethod Shipping { get; init; }





        public decimal GetTotal()
        {
            // Ціна товару зі знижкою + вартість доставки

            decimal total = Discount.ApplyDiscount(Product.Price) + Shipping.Cost;
            return total;

        }


            
    
    }
    }