using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Factors
    {
        public  void checkfactors()
        {
            int n, i;
            Console.WriteLine("Enter Number to find the prime factors");

            n = 0;
            Console.ReadLine();

            Console.WriteLine("factors");
            for (i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine("The prime factor of the number {0} is: {1}", n, i);
                    n = n / i;
                }
                Console.ReadLine();
            }
        }
    }
}
    

