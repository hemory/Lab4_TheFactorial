using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepGoing;
            do
            {

                Console.WriteLine("Welcome to the Factorial Calculator \n\n Please enter a number that is greater than 0 but less than 10");
                int numberToBeFactored = int.Parse(Console.ReadLine());
                TheFactor calculator = new TheFactor();
                Console.WriteLine("The factorial of \t" + numberToBeFactored + "\t is \t" +Factorial(numberToBeFactored));

                Console.WriteLine("Continue y/n?");
                keepGoing = Console.ReadLine();

            } while (keepGoing == "y");
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();


        }

        static long Factorial(int numberToBeFactored) //This is a method
        {

            int i;
            long factoredNumber;

            factoredNumber = numberToBeFactored;
            for (i = numberToBeFactored - 1; i >= 1; i--)
            {
                factoredNumber = factoredNumber * i;
            }
            return factoredNumber;
        }
       
    }
    }
//long factorialRecur(int numberToBeFactored);

//{if(numberToBeFactored = 1) return 1;

//    }else return numberToBeFactored* factorialRecur(numberToBeFactored - 1);











