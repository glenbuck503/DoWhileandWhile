using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try and guess my favorite Number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            bool guessed = userNum == 4;

            do
            {
                switch (userNum)
                {
                    case 10:
                        Console.WriteLine("Nope! Try again!");
                        Console.WriteLine("Guess a different number");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("Nope! Try again!");
                        Console.WriteLine("Guess a different number");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("Nope! Try again!");
                        Console.WriteLine("Guess a different number");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("Nope! Try again!");
                        Console.WriteLine("Guess a different number");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("AhHah! Correct! Nice Guess!");
                        guessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope! Try again!");
                        Console.WriteLine("Guess a different number");
                        userNum = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (!guessed);
            Console.Read();
            
            
        }
    }
}
