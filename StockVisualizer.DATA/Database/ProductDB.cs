using System;
using System.Collections.Generic;
using System.Text;
using StockVisualizer.DATA.Model;
namespace StockVisualizer.DATA.Database
{
    public class ProductDB
    {
        public List<Product> Stock = new List<Product>()
        {
            new Product("PD001", "Reading Table", 7, 2, 20000) { },
            new Product("PD002", "Reading Lamp", 7, 2, 30000) { },
            new Product("PD003", "Monitor Desk", 7, 2, 56000) { },

        };
       
    }
}
