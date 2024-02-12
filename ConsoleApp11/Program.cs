using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {

    
        static void Main(string[] args)
        {
            double S(double X, int k = 10)
            {
                if (k == 1)
                {
                    return 2 * X;
                }
                else 
                    return (k + 1) * X / k + S(X, k -= 1);
            }
            Console.Write("X = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(S(x));
        }
    }
}
