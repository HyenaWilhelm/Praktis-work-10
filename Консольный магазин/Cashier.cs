using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольный_магазин
{
    internal class Cashier
    {
        public string cashierlogin = "cashier";
        public string cashierpassword = "cashier";

        int a = 0;

        public void Cashier_Menu()
        {
            Program program = new Program();
            Sklad sklad = new Sklad();

            
            string text = File.ReadAllText("C:\\Рабочий стол\\Products.json");
            List<string> product = JsonConvert.DeserializeObject< List<string>>(text);
            Console.WriteLine(text);

            for (int i = 0; i != 15; i++)
            {
                sklad.Product_Info2();
                Console.SetCursorPosition(95, i);
                Console.WriteLine("|");
            }

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.A)
            {
                sklad.product_name = Console.ReadLine();
                product.Add(sklad.product_name);
                Console.Clear();
            }
            else if (key.Key == ConsoleKey.D)
            {
                sklad.product_ID = Convert.ToInt32(Console.ReadLine());
                product.RemoveAt(sklad.product_ID);
                Console.Clear();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                program.Start();
            }
            else if (key.Key == ConsoleKey.S)
            {
                string json = JsonConvert.SerializeObject(product);
                File.WriteAllText("C:\\Рабочий стол\\Chek.json", json);
            }
            else if (key.Key == ConsoleKey.T)
            {
                sklad.product_ID = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(5, 3);
                Console.WriteLine(sklad.product[sklad.product_ID]);
                Console.SetCursorPosition(10, 3);
                Console.WriteLine(sklad.products_prices[sklad.product_ID]);
                
            }
        }
    }
}
