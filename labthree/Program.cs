using System;

namespace labthree
{
    class Program
    {
        static void Main()
        {
            bool run = true;
            while (run == true)
            {
                int i, input1;

                Console.WriteLine("Learn your squares and cubes! \n");
                Console.WriteLine("Please enter an integer");
                input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("The squares and the cubes of the numbers up until the integer you entered are: \n");
                Console.WriteLine("Number  Squared  Cubed");
                Console.WriteLine("======= ======= =======");
                for (i = 1; i <= input1; i++)
                {
                    Console.WriteLine("{0} \t {1} \t {2}", i, (i * i), (i * i * i));
                }

                run = Continue();
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;

            if (input == "y")
            {
                goOn = true;
            }

            else if (input == "n")
            {
                goOn = false;
            }

            else
            {
                Console.WriteLine("I don't understand that, let's try again:");
                goOn = Continue();
            }
            return goOn;
        }
    }
}













