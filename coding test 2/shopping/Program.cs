using System;

namespace shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart online = new Cart();

            Items xbox = new Items();
            xbox.ItemName = "Xbox";
            xbox.ItemPrice = 3950.99M;
            online.AddItem(xbox);

            Items ps = new Items();
            ps.ItemName = "PS4";
            ps.ItemPrice = 5999.49M;
            online.AddItem(ps);

            string display = online.GetCartWithTotals();
            Console.WriteLine(display);
        }
    }
}
