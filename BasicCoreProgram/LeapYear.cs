using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public  class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the year you want to check for leap year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else
                Console.WriteLine("It is  not a leap year");
            {

            }
        }
    }
}

    }
}
