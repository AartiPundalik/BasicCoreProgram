using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
                Console.WriteLine("1.FlipCoin");
                Console.WriteLine("Enter a option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.coin();
                        break;
                case 2:
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.Power();
                    break;
                case 4:
                    HarmonicNum Harmonic = new HarmonicNum();
                    Harmonic.Harmonic();
                    break;
                case 5:
                    Factors checkfactors = new Factors();
                    checkfactors.checkfactors();
                    break;

            }
            Console.ReadLine();
            }
        }
    }


    

