using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers_finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int number, sum, factorOrnot;
            

            //taking inputs from user
            Console.Write("Enter the lower bound of the range : ");
            int start= int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound of the range : ");
            int end = int.Parse(Console.ReadLine());
            
            //swap numbers if end is less than start
            if(end<start)
            {
                start = start + end;
                end = start - end;
                start = start - end;
            }

            Console.WriteLine();
            Console.WriteLine("The Perfect numbers within this range are : ");



            //loop to iterate within the range only
            for (number = start; number <= end; number++)
            {
                //variable to start factors from 1
                factorOrnot = 1;
                //variable to contain sum of factors of the number 
                sum = 0;
                
                while (factorOrnot < number)
                {
                    //condition to find factor
                    if (number % factorOrnot == 0)
                        sum = sum + factorOrnot;
                    factorOrnot++;
                }
                if (sum == number)
                    Console.WriteLine(number);
            }










        }
    }
}
