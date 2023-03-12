using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Консольный_магазин
{
    internal class MenuNavigation
    {
        public int position = 0;
        
        public void Down()
        {
            position--;
            Console.WriteLine("->");
        }
        public void Up()
        {
            position++;
            Console.WriteLine("->");
        }
    }
}
