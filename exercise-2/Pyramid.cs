using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SecondApp
{
    public class Pyramid
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input Number For Pyramid Layer");
            int layers = Convert.ToInt32(Console.ReadLine());
            int Space = 0;
            int Number = 0;
            Console.WriteLine("Printing Pyramid");
            for (int i = 1; i <= layers; i++)  
            {  
                for (Space = 1; Space <= (layers - i); Space++){
                    Console.Write(" ");  
                }
                for (Number = 1; Number <= i; Number++){
                    Console.Write('*');
                } 
                for (Number = (i - 1); Number >= 1; Number--){
                    Console.Write('*');
                }
                Console.WriteLine();  
            }       
        }
    }
}
