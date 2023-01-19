using System;

namespace StockVisualizer.DATA.Model
{
    public class Product
    {
        
        public string ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public int OrderCount { get; set; }
        public double Price { get; set; }
         
        public Product(string id, string name, int quantity,string category, int orderCount,double price )
        {
            ID = id;
            Name = name;
            Quantity = quantity;
            OrderCount = orderCount;
            Price = price;
            Category = category;
            
        }
    }
}
