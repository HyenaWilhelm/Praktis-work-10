using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Консольный_магазин
{
    public class Sklad
    {
        public string skladlogin = "sklad";
        public string skladpassword = "sklad";

        public string product_name;
        public int product_ID;
        public string product_price;

        Program program = new Program();
        Class1 serial = new Class1();

        public List<string> product = new List<string>();
        public List<string> products_prices = new List<string>();
        public void Sklad_functional()
        {
            
        Console.CursorVisible = true;
            while (true)
            {
                for (int i = 0; i != 15; i++)
                {
                    Product_Info2();
                    Product_Info();
                    Console.SetCursorPosition(95, i);
                    Console.WriteLine("|");
                }   
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.A)
                {
                    Console.WriteLine("Введите имя: ", product_name = Console.ReadLine());
                    product.Add(product_name);
                    Console.WriteLine("Введите ID", product_price = Console.ReadLine());
                    products_prices.Add(product_price);
                    Console.Clear();
                    Sklad_functional();
                }
                else if (key.Key == ConsoleKey.D)
                {
                    product_ID = Convert.ToInt32(Console.ReadLine());
                    product.RemoveAt(product_ID);
                    products_prices.RemoveAt(product_ID);
                    Console.Clear();
                    Sklad_functional();
                }
                else if (key.Key == ConsoleKey.T)
                {
                    product_ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(product_ID);
                    Console.WriteLine(product[product_ID]);
                    Console.Clear();
                    Sklad_functional();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    program.Start();
                }
                else if (key.Key == ConsoleKey.S)
                {
                    string json = JsonConvert.SerializeObject(product);
                    File.WriteAllText("C:\\Рабочий стол\\Products.json", json);
                    Sklad_functional();
                }
            }
        }
        private void Product_Info()
        {
            Console.SetCursorPosition(97, 7);
            Console.WriteLine("T - поиск товара по ID");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Имя товара");
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Цена");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("Выберите операцию: ");
        }
        public void Product_Info2()
        {
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("S - Завершить покупку");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("Esc - На главный экран");
            Console.SetCursorPosition(97, 5);
            Console.WriteLine("A - Добавить товар");
            Console.SetCursorPosition(97, 6);
            Console.WriteLine("D - Удалить товар");
        }
    }
}
