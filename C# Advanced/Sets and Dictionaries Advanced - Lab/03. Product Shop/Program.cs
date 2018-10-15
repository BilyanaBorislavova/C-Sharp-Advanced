using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shopDict = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] productShopInfo = command.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string shop = productShopInfo[0];
                string product = productShopInfo[1];
                double price = double.Parse(productShopInfo[2]);

                if(!shopDict.ContainsKey(shop))
                {
                    shopDict.Add(shop, new Dictionary<string, double>());
                }

                shopDict[shop].Add(product, price);

                command = Console.ReadLine();
            }

            foreach (var shop in shopDict.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
