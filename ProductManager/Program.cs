using StockVisualizer.BLL.Implementation;
namespace ProductManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockDisplayer stockDisplayer = new();

            stockDisplayer.DisplayProducts("id,name,price");
        }
    }
}