using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class SwappingNumberProblem
    {
        public void SwapTwoNumber()
        {
            Console.Write("Enter the First number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After Swapping these Two Numbers are:\nFirst number is: " + firstNumber + "\nAnd Second number is: " + secondNumber);
        }
    }
}
