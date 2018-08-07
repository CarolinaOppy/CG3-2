using System;

namespace Guess_my_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //establishing program and asking for variable.//
            Console.WriteLine("Hello, let's play a game!");
            Console.WriteLine("Guess a number between 1-10.");
            var number = Console.ReadLine();
            
            //inline statement of the boolean//
            string message = (number == "8") ? "You win!" : "You lose." ;

            //output//
            Console.WriteLine(message);
            Console.ReadLine();
            
            

         
        }
    }
}
