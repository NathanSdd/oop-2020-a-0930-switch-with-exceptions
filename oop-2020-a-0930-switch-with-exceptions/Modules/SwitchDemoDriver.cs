using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2020_a_0930_switch_with_exceptions.Modules
{
    internal class SwitchDemoDriver
    {
        public static void Run()
        {
            SwitchDemo();

        }
        public static void SwitchDemo()
        { 
            Console.WriteLine("Switch Demo");
            int number = 3;
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}

