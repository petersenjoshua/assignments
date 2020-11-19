using System;

namespace hangman
{
    class Program
    { 
        static int Rand_array()
        {
            Random array = new Random();
            return arr.Next(0, 5);
        }
        
        static int Rand_index()
        {
            Random index = new Random();
            return index.Next(0, 10);
        }
        static void Main(string[] arg)
        {
           
            int a = Rand_array();
            int b = Rand_index();
           
            Console.WriteLine("THE HANGMAN GAME!\nENJOY!\n\nNote : all user inputs shoukd be in small letters.\n");

           
            string[] fruit = { "orange", "mango", "melon", "lime", "lemon", "garlic", "grape", "spinach", "pears", "plums" };
            string[] colour = { "violet", "wine", "pink", "brown", "tan", "red", "blue", "grey", "black", "white" };
            string[] country = { "serbia", "china", "turkey", "iceland", "korea", "spain", "egypt", "uae", "brazil", "ethopia" };
            string[] name = { "joseph", "drogba", "Faith", "ronald", "justin", "bruyne", "sterling", "bale", "arnold", "jack" };
            string[] food = { "sandwich", "pie", "rice", "fish", "bagel", "yam", "tacos", "lobster", "beans", "maize" };

            
            string[][] cartegories = new string[][] {
                fruit,
                colour,
                country,
                name,
                food,
            };
            string type = "";

            
            if (a == 0)
                type = "Fruit";
            if (a == 1)
                type = "Colour";
            if (a == 2)
                type = "Country";
            if (a == 3)
                type = "Name";
            if (a == 4)
                type = "Food";

            
            Console.WriteLine("\nYour word is a {0}.\nGoodluck!\n\n", type);
            Console.Write("\t\t");

            
            int wordlength = cartegories[a][b].Length;
            
            string wordline = "";
            string word = cartegories[a][b];
            
           
            int letter_index;

            
            for (int x = 0; x < wordlength; x++)
            {
                wordline += "_ ";
            }

            
            Console.WriteLine(wordline);
            Console.WriteLine("\nStart guessing : )\n");
            
            char guess = 'a';

            
            for (int x = 5; x > 0;)
            {
                Console.Write("\n{0} tries left : ", x);
                if (wordline.Contains("_"))
                { }
                else
                {
                    Console.WriteLine("\n\nCONGRATS!! YOU'RE AWESOME! YOU WON!\n\nThe answer : {0}", word);
                    break;
                }
                guess = Convert.ToChar(Console.ReadLine());
                if (word.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                    letter_index = word.IndexOf(guess) * 2;
                    wordline = wordline.Insert(letter_index, Convert.ToString(guess));
                    wordline = wordline.Remove(letter_index + 1, 1);
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    if (x == 1)
                        Console.WriteLine("\nYou lost! Never give up! The answer : {0}.\nTRY AGAIN!", word);
                    --x;
                }
                Console.WriteLine("\n\t{0}", wordline);


            }
            Console.WriteLine("\n\n\nENIOLA O.A");
            Console.ReadLine();
        }
    }
}



