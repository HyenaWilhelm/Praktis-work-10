using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Консольный_магазин
{
    internal class Autorise
    {
        Admin admin = new Admin();
        Cashier cashier = new Cashier();
        Sklad sklad = new Sklad();
        hr kadr = new hr();

        public int check = 0;
        public string password;
        public string login;

        public void Autorisation()
        {
            Console.WriteLine("Введите логин: ");
            login = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            password = Console.ReadLine();

            while (login == admin.adminlogin || login == cashier.cashierlogin || login == sklad.skladlogin)
            {
                if (login == admin.adminlogin)
                {
                    if (password == admin.adminpassword)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы успешно вошли в систему");
                        check = 1;
                        break;
                    }
                }
                else if (login == cashier.cashierlogin)
                {
                    if (password == cashier.cashierpassword)
                    {
                        Console.WriteLine("Вы успешно вошли в систему");
                        Console.Clear();
                        check = 2;
                        break;
                    }
                }
                else if (login == sklad.skladlogin)
                {
                    if (password ==  sklad.skladpassword)
                    {
                        Console.WriteLine("Вы успешно вошли в систему");
                        Console.Clear();
                        check = 3;
                        break;
                    }
                }
                else if (login == kadr.hrlogin)
                {
                    if (password == kadr.hrpassword)
                    {
                        Console.WriteLine("Вы успешно вошли в систему");
                        Console.Clear();
                        check = 4;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль. Введите ещё раз.");
                    Console.Clear();
                }
            }
        }
    }
}
