using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApp
{

    class GuessTheNumber
    {
        public static void main(String[] args){
            int tryNumber = 0;
            Console.WriteLine("Input min and max values to generate random number from this range");
            Console.WriteLine("Input min");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input max");
            int max = Convert.ToInt32(Console.ReadLine())+1;
            string wannaPlay = "yes";
            while(wannaPlay.ToLower().Equals("yes")){
                Console.WriteLine("System Generated Random Number");
                int randValue = new Random().Next(min,max);
                Console.WriteLine("Guess The Number ...");
                int userInput = Convert.ToInt32(Console.ReadLine());
                while(userInput != randValue){
                    tryNumber++;
                    Console.WriteLine("Missed it but try again...");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Congrats!!! You Guessed The Number...");
                Console.WriteLine("Wanna Play Again?");
                Console.WriteLine("To Continue enter Yes, To Stop enter No");
                wannaPlay = Console.ReadLine();
            }
            Console.WriteLine("Bye!");
        }
    }
}
