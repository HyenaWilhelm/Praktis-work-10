using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Консольный_магазин
{
    internal class Admin
    {
        public string adminpassword = "admin";
        public string adminlogin = "admin";

        MenuNavigation arrows = new MenuNavigation();

        public void Admin_Functional()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.Key == ConsoleKey.DownArrow)
            {

            }
        }
    }
}
