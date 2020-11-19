using System;
using System.Collections.Generic;
using System.Text;

namespace shopping
{
   public class Cart
    {
        private List<Items> Items;
        public Cart()
        {
            Items = new List<Items>();
        }

        public void AddItem(Items item)
        {
            Items.Add(item);
        }

        public string GetCartWithTotals()
        {
            StringBuilder builder = new StringBuilder();

            decimal subTotal = Calculations.CalculateSubTotal(Items);
            decimal subTotalWithVat = Calculations.CalculateWithVat(Items);

            foreach (Items item in Items)
            {
                builder.AppendLine(item.ItemName + " " + item.ItemPrice.ToString("N2"));
            }

            builder.AppendLine("Sub Total:   " + subTotal.ToString("N2"));
            builder.AppendLine("With VAT:   " + subTotalWithVat.ToString("N2"));

            return builder.ToString();

        }

    }
}
