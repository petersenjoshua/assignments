using System;
using System.Linq;

namespace msp_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        { 

        {

            static bool HelperConvertNumberToText(int num, out string buf)

            {

                string[] strones = {

            "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",

            "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",

            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",

          };



                string[] strtens = {

              "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty",

              "Seventy", "Eighty", "Ninety", "Hundred"

          };



                string result = "";

                buf = "";

                int single, tens, hundreds;



                if (num > 1000)

                    return false;



                hundreds = num / 100;

                num = num - hundreds * 100;

                if (num < 20)

                {

                    tens = 0; // special case

                    single = num;

                }

                else

                {

                    tens = num / 10;

                    num = num - tens * 10;

                    single = num;

                }



                result = "";



                if (hundreds > 0)

                {

                    result += strones[hundreds - 1];

                    result += " Hundred ";

                }

                if (tens > 0)

                {

                    result += strtens[tens - 1];

                    result += " ";

                }

                if (single > 0)

                {

                    result += strones[single - 1];

                    result += " ";

                }



                buf = result;

                return true;

            }



            static bool ConvertNumberToText(int num, out string result)

            {

                string tempString = "";

                int thousands;

                int temp;

                result = "";

                if (num < 0 || num > 100000)

                {

                    System.Console.WriteLine(num + " \tNot Supported");

                    return false;

                }



                if (num == 0)

                {

                    System.Console.WriteLine(num + " \tZero");

                    return false;

                }



                if (num < 1000)

                {

                    HelperConvertNumberToText(num, out tempString);

                    result += tempString;

                }

                else

                {

                    thousands = num / 1000;

                    temp = num - thousands * 1000;

                    HelperConvertNumberToText(thousands, out tempString);

                    result += tempString;

                    result += "Thousand ";

                    HelperConvertNumberToText(temp, out tempString);

                    result += tempString;

                }

                return true;

            }



            static void Main(string[] args)

            {

                string result;

                int i, num;

                int[] arrNum =

                {

            -1, 0, 5, 10, 15, 19, 20, 21, 25, 33, 49, 50, 72,

            99, 100, 101, 117, 199, 200, 214, 517, 589, 999,

            1000, 1010, 1018, 1200, 9890, 10119, 13535, 57019,

            99999, 100000, 100001

          };



                for (i = 0; i < arrNum.Count(); i++)

                {

                    num = arrNum[i];

                    if (ConvertNumberToText(num, out result) == true)

                        Console.WriteLine(num + "\t" + result);

                }

            }

        }

    }


}
    }

