using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoin
    {
        int counthead = 0;
        int countTail = 0;

        public void coin()
        {


            Console.WriteLine("Enter the number of times to flip the coin");
            int flipNum = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < flipNum; i++)
            {
                double numcheck = random.NextDouble();
                if (numcheck > 0.5)
                    counthead++;
                else
                    countTail++;
            }
            Console.WriteLine(counthead + " " + countTail);
            float headPercentage = (float)counthead / flipNum * 100;
            float tailpercentage = (float)countTail / flipNum * 100;
            Console.WriteLine(headPercentage + " " + tailpercentage);
        }
    }
}




    

