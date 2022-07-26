using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class FactorsProblem
    {
        public void Factors()
        {
            Console.Write("Enter the number to be find prime factors: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("\t" + i);
                }
            }
        }
    }
}
