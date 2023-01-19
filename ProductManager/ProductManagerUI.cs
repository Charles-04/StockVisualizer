using StockVisualizer.BLL.Implementation;

namespace ProductManager
{
    internal static class ProductManagerUI
    {
        static StockDisplayer stockDisplayer = new();


        internal static void Run()
        {
            Console.WriteLine($"\t Product Displayer \t \n\n");

        Start: try
            {
                Console.WriteLine(@"
     Select options
     1: Display all Products info
     2: Display Specified Product info
     3: Exit
");

                var isOptionValid = (int.TryParse(Console.ReadLine(), out int option));
                if (isOptionValid)
                {
                    switch (option)
                    {
                        case 1:
                            stockDisplayer.DisplayProducts();
                            goto Start;
                        case 2:
                            GetCustomDisplay();
                            goto Start;
                        case 3:
                            Environment.Exit(000);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            static void GetCustomDisplay()
            {
            CustomDisplay: Console.WriteLine("Enter properties to be displayed seperated by commas (,)");
                var properties = Console.ReadLine();
                if (!(string.IsNullOrEmpty(properties)))
                {
                    stockDisplayer.DisplayProducts(properties);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Properties can't be empty");
                    Thread.Sleep(3000);
                    Console.ResetColor();
                    Console.Clear();
                    goto CustomDisplay;
                }

            }
        }
    }
}
