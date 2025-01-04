using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This minigame is supposed to give you two random numbers to multiply and have you type the resulting number.
// if you type the wrong answer you will have 4 more trys to get the right answer, and if you answer it right, you can choose between exiting the program and playing again.

namespace Multiplication_Minigame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool success = true;

            while (success)
            {

                //Generates two random numbers and initializes the answer
                Random rnd = new Random();

                int numberA = (rnd.Next(100));

                int numberB = (rnd.Next(100));

                int answer = numberA * numberB;

                int Input = 0;


                Console.Write("Whats the Value of " + numberA + " x " + numberB + "?");
                Console.WriteLine();

                //turns the answering part into a loop IF the answer is wrong
                do
                {
                    Console.WriteLine();
                    Console.Write("Enter your answer: ");
                    string answerInput = Console.ReadLine();
                    if (int.TryParse(answerInput, out Input)) // prevents the program from encountering a parsing error when the input is not a number 
                    {
                        success = false;
                    }    
                    else 
                    {
                        if (answer != Input)

                        Console.WriteLine();
                        Console.WriteLine("wrong.");
                    }
                } while (answer != Input);

                Console.WriteLine();
                Console.WriteLine("you guessed right, Good job!");
                    
                        



            }


            Console.ReadLine();
        }
    }
}
