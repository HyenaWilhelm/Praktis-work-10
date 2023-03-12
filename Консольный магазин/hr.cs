using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Консольный_магазин
{
    internal class hr
    {
        MenuNavigation arrows = new MenuNavigation();
        Program program = new Program();

        public string hrlogin = "hr";
        public string hrpassword = "hr";

        public string role_name;
        public int role_ID;

        public List<string> Role_Name = new List<string>();
        public List<int> Role_ID = new List<int>();

        public void hrStart()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                for (int i = 0; i != 15; i++)
                {
                    Operation_Info();
                    Console.SetCursorPosition(95, i);
                    Console.WriteLine("|");
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    arrows.Down();
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    arrows.Up();
                }
                else if (key.Key == ConsoleKey.A)
                {
                    Console.WriteLine("Введите имя: ", role_name = Console.ReadLine());
                    Role_Name.Add(role_name);
                    Console.WriteLine("Введите ID", role_ID = Convert.ToInt32(Console.ReadLine()));

                    Role_ID.Add(role_ID);
                    Console.Clear();
                    hrStart();
                }
                else if (key.Key == ConsoleKey.D)
                {
                    role_ID = Convert.ToInt32(Console.ReadLine());
                    Role_Name.RemoveAt(role_ID);
                    Role_ID.RemoveAt(role_ID);
                    Console.Clear();
                    hrStart();
                }
                else if (key.Key == ConsoleKey.T)
                {
                    role_ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(role_ID);
                    Console.WriteLine(Role_Name[role_ID]);
                    Console.Clear();
                    hrStart();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    program.Start();
                }
                else if (key.Key == ConsoleKey.S)
                {
                    string json = JsonConvert.SerializeObject(Role_Name);
                    File.WriteAllText("C:\\Рабочий стол\\Roles.json", json);
                    hrStart();
                }
            }
        }
        public void Operation_Info()
        {
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("S - Сохранить результат");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("Esc - На главный экран");
            Console.SetCursorPosition(97, 5);
            Console.WriteLine("A - Добавить роль");
            Console.SetCursorPosition(97, 6);
            Console.WriteLine("D - Удалить роль");
        }
    }
}
