using System;
using System.Threading;

namespace TabOfPowers
{
    class Program
    {
        public static void CreateTable(int length)
        {
            //Display table of squares & cubes until integer
            Console.WriteLine("Number\t\tSquared\t\tCubed");
            Console.WriteLine("=======\t\t=======\t\t=======");

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine($"{i}\t\t{(i * i)}\t\t{(i * i * i)}");
            }
        }

        public static void ProgramStart()
        {
            //Prompt user for integer
            Console.WriteLine("Do you want to learn your squares and cubes!?(Y/N)");

            string userCont = Console.ReadLine();
            while (userCont == "Y")
            {
                Console.WriteLine("Enter an integer:");
                string number = Console.ReadLine();
                int length = int.Parse(number);
                if (length > 1290)
                {
                    Console.WriteLine("This number is too large");
                }
                else if (length < 1)
                {
                    Console.WriteLine("Enter a Positive number.");
                }
                else
                {
                    CreateTable(length);
                }

                //Prompts user to continue
                Console.WriteLine("Do you want to try again? (Y/N)");
                userCont = Console.ReadLine();
            }
            Console.WriteLine("Thank you for learning!");
        }
        static void Main(string[] args)
        {
            ProgramStart();
        }
    }
}
