using System;

namespace numConvert
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to convert it to words:");
            string stringNum = Console.ReadLine();
            int number = Int32.Parse(stringNum);

            string newNumber = ConvertToWord(number);
            Console.WriteLine(newNumber);
        }
        public static string NumberToWords(int number)
        {
            if (number == 0) return "zero";
            if (number < 0) return "minus" + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + "thousand";
                 number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + "hundred";
                number %= 100;
            }

            if ((number / 100) > 0)
            {
                if (words != "") words += "and";

                var unitsMap = new[] {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
                              "Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};
                var tensMap = new[] { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];

                    if ((number % 10) > 0) words += "-" + unitsMap[number % 10];
                }

            }
            return words;
        }
        
    }
}
