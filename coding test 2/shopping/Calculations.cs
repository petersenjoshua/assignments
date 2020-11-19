using System;
using System.Collections.Generic;

namespace shopping
{
    public class Calculations
    {
       

       


        public static decimal CalculateSubTotal(List<Items> calculationItems)
        {
            decimal total = 0;
            foreach (Items item in calculationItems)
            {
                total += item.ItemPrice;
            }
            return total;
        }

        public static decimal CalculateWithVat(List<Items> calculationItems)
        {
            decimal subTotal = CalculateSubTotal(calculationItems);
            return subTotal * ((100 + Tax.VatAmount) / 100);
        }


    }
}