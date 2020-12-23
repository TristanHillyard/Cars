using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number");
            int favNum = Convert.ToInt32(Console.ReadLine());
            bool myGuess = favNum == 17;


            do
            {
                while (!myGuess)
                {
                    switch (favNum)
                    {
                        case 12:
                            Console.WriteLine("Wrong guess.");
                            Console.WriteLine("Guess again.");
                            favNum = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("You guessed wrong.");
                            Console.WriteLine("Guess again");
                            favNum = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 22:
                            Console.WriteLine("You guessed wrong.");
                            Console.WriteLine("Guess again");
                            favNum = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 10:
                            Console.WriteLine("You guessed wrong.");
                            Console.WriteLine("Guess again.");
                            favNum = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 17:
                            Console.WriteLine("You guess my favorite number!");
                            myGuess = true;
                            break;
                        default:
                            Console.WriteLine("You guessed wrong.");
                            Console.WriteLine("Guess again.");
                            favNum = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
            }
            while (myGuess);

            Console.Read();
        }
    }
}
