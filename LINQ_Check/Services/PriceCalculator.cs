using LINQ_Check.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Check.Services
{
    public static class PriceCalculator
    {

        public static decimal CalculateFinalPrice(ProductDto product, IDiscountStrategy discount)
        {

            return discount.ApplyDiscount(product.Price);

        }




    public static void PrintReceipt(ProductDto product, IDiscountStrategy discount)
        {
            // Виведи: назва товару, оригінальна ціна, Description знижки, фінальна ціна

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(discount.Description);
            Console.WriteLine(CalculateFinalPrice( product,  discount));
        }


    }

}