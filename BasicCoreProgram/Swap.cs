using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Swap
    {

        public  void checkswap()
        {
            int num1, num2, temp;

            Console.WriteLine("Enter first number");
            num1 = 100;
            Console.ReadLine();

            Console.WriteLine("Enter second number");

            num2 = 200;
            Console.ReadLine();

            Console.WriteLine("Values before swapping: num1=" + num1 + " and num2=" + num2);

            temp = num1;

            num1 = num2;

            num2 = temp;

            Console.WriteLine("Values after swapping: num1=" + num1 + " and num2=" + num2);



            Console.ReadLine();
        }
    }
}

