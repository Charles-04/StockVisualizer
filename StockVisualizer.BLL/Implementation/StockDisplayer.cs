using StockVisualizer.DATA.Database;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace StockVisualizer.BLL.Implementation
{
    public class StockDisplayer
    {


        public  void DisplayProducts()
        {
            foreach (var item in ProductDB.Stock)
            {
                Console.WriteLine(@$"
                Product ID          : {item.ID}
                Product Name        : {item.Name}
                Product Category    : {item.Category}
                Product Quantity    : {item.Quantity}
                Product Order Count : {item.OrderCount}
                Product Price       : {item.Price}

");
            }
        }

        public  void DisplayProducts(string properties)
        {

            var property = properties.Split(",");

            dynamic productinfo = new ExpandoObject();

            foreach (var item in ProductDB.Stock)
            {
                productinfo.ID = item.ID;
                productinfo.Name = item.Name;
                productinfo.Category = item.Category;
                productinfo.Quantity = item.Quantity;
                productinfo.OrderCount = item.OrderCount;
                productinfo.Price = item.Price;

                foreach (var props in (IDictionary<String, Object>)productinfo)
                {
                    foreach (var prop in property)
                    {
                        if (prop.ToLower() == props.Key.ToLower())
                        {
                            Console.WriteLine($"{props.Key} \t : \t  {props.Value}");
                        }
                    
                    }

                }
            }
        }

    }
}
