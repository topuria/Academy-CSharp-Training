using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApp
{

    class Numbers
    {
        public static void main(String[] args){
            Console.WriteLine("Task 1 - Calculate Prime Numbers");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(int i = 1;i<=inputNumber;i++){
                if(inputNumber % i == 0){
                    flag++;
                }
            }
            if(flag == 2){
                Console.WriteLine(inputNumber+" Is A Prime Number");
            }else{
                Console.WriteLine(inputNumber+" Is Not A Prime Number");
            }

            Console.WriteLine("Task 2 - number of dividers");
            Console.WriteLine(inputNumber+ " has "+flag+" Dividers");
        }
    }
}
