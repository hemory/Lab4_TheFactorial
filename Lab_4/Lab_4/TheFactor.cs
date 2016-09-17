using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class TheFactor
    {
        public long Factorial(int numberToBeFactored) //This is a method
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
