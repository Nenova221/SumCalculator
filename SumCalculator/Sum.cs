using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculator
{
    public class Sum
    {
        public static double CalculatingSum(double input, double expectedSum)
        {
            Console.Write("Enter last number: ");
            int length = Int32.Parse(Console.ReadLine());
            double sum = 1.0;
            for (int i = 2; i <= length; i++)
            {
                sum += (1.0 / i);
            }
            return sum;
        }
    }
}
