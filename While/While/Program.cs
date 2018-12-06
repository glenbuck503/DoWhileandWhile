using System;


namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you think my name is?");
            string name =(Console.ReadLine());
            bool guessed = false;
           
            while (!guessed)
            {
                switch (name)
                {
                    case "Tim":
                        Console.WriteLine("Sorry, that is not my name!");
                        Console.WriteLine("What do you think my name is?");
                        name = (Console.ReadLine());
                        break;
                    case "Ben":
                        Console.WriteLine("Sorry, that is not my name");
                        Console.WriteLine("What do you think my name is?");
                        name = (Console.ReadLine());
                        break;
                    case "Jordan":
                        Console.WriteLine("Sorry,that is not my name");
                        Console.WriteLine("What do you think my name is?");
                        name = (Console.ReadLine());
                        break;
                    case "Glen":
                        Console.WriteLine("THAT IS MY NAME!");
                        guessed = true;
                        break;
                    default:
                        Console.WriteLine("Not even close!");
                        Console.WriteLine("What do you think my name is?");
                        name = (Console.ReadLine());
                        break;

                }

            }
            
            Console.Read();

            
        }
    }
}
