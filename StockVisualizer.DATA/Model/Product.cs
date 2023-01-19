using System;

namespace StockVisualizer.DATA.Model
{
    public class Product
    {
        
        private string ID { get; set; }
        private string Name { get; set; }
        private int Quantity { get; set; }
        private int OrderCount { get; set; }
        private double Price { get; set; }

        public Product(string id, string name, int quantity, int orderCount,double price )
        {
            ID = id;
            Name = name;
            Quantity = quantity;
            OrderCount = orderCount;
            Price = price;
            
        }
    }
}
