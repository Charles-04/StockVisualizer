using System;
using System.Collections.Generic;
using System.Text;
using StockVisualizer.DATA.Model;
namespace StockVisualizer.DATA.Database
{
    public static class ProductDB
    {
        public static List<Product> Stock = new List<Product>()
        {
            new Product("PD001", "Reading Table", 7,"goods",3, 20000) { },
            new Product("PD002", "Reading Lamp", 7, "goods", 3,30000) { },
            new Product("PD003", "Monitor Desk", 7, "goods", 3,56000) { },

        };
       
    }
}
