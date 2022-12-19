using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_code_for_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int start, end, number, factor;
            bool primeOrnot;



            //prompt user to enter the first number
            Console.WriteLine("Enter lower bound of the range");
            start = int.Parse(Console.ReadLine());
            

            //prompt user to enter the second number
            Console.WriteLine("Enter upper bound of the range");
            
            end = int.Parse(Console.ReadLine());


            //swap both of the numbers if the second number is greater
            if(start > end)
            {
                start = start + end;
                end = start - end;
                start = start - end;
            }


            //print that the prime numbers in the given range are

            Console.WriteLine("prime numbers within this range are: ");

            //loop to ensure that the code works only within the given range
            for(number= start ; number <= end ; number++ )
            {
                //because 1 and 0 are neither prime nor composite
                if (number == 0 || number == 1)
                    continue;

                //variable to tell if number is prime or not
                primeOrnot = true;

                
                for ( factor = 2; factor < number; factor++)
                {
                   
                    //condition to check if number is prime
                    if(number%factor == 0)
                    {
                        primeOrnot = false;
                        break;
                    }
                }
                
                //to declare if number is a prime number then we print it
                if(primeOrnot == true)
                {
                    Console.WriteLine(number);
                }

               
            }
            

















        }
    }
}
