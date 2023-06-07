using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApp
{

    class MultipleInput
    {
        public static void main(String[] args){

            Console.WriteLine("შეიყვანე ნებისმიერი მთელი რიცხვი, რაოდენობა არ არის შეზღუდული უბრალოდ გამოყავი სფეისით");
            String input = Console.ReadLine();
            String[] inputNumbers = input.Split(' ');
            int sum = 0;
            int x = 0;
            for(int i = 0; i<inputNumbers.Length;i++){
                if(Convert.ToInt32(inputNumbers[i]) > 0){
                    sum+=Convert.ToInt32(inputNumbers[i]);
                    x++;
                }
            }
            Console.WriteLine("ჯამი არის "+sum);
            Console.WriteLine("საშვალო არის "+ sum/x);
        }
    }
}
