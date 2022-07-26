using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class HarmonicProblem
    {
        public void HarmonicNumber()
        {
            double harmonicSum = 0 ;
            Console.Write("Enter the number to find Harmonic number : ");
            double num = Convert.ToDouble(Console.ReadLine());

            for (double i = 1; i <= num; i++)
            {
                Console.Write("1/{0} +", i);
                harmonicSum += (1 / i);
            }
            Console.WriteLine("\n The Sum of harmonic number is:" + harmonicSum);

        }
    }
} 
