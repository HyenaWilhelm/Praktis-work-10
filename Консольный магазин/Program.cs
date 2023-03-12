namespace Консольный_магазин
{
    public class Program
    {
        static void Main()
        {

            Autorise autorise = new Autorise();
            Admin admin = new Admin();
            Cashier cashier = new Cashier();
            Sklad sklad = new Sklad();
            hr kadr = new hr();

            ConsoleKeyInfo key = Console.ReadKey();
            Console.CursorVisible = false;
            autorise.Autorisation();
            if (autorise.check == 1)
            {
                admin.Admin_Functional();
            }
            else if (autorise.check == 2)
            {
                cashier.Cashier_Menu();
            }
            else if (autorise.check == 3)
            {
                sklad.Sklad_functional();
            }
            else if (autorise.check == 4)
            {
                kadr.hrStart();
            }
        }
        public void Start()
        {
            Main();
        }
    }
}