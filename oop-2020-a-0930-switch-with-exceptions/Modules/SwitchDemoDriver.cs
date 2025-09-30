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
            SwitchExpressionDemo();
            DayOfWeek();
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
        public static void SwitchExpressionDemo()
        {
            Console.WriteLine("Switch Expression Demo");    
            int number = 3;
            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other"
            };
            Console.WriteLine(result);  
        }


        public static void DayOfWeek()
        {
            Console.WriteLine("DayOfWeek Demo");
            int dayNumber = 3; //Example: 3 means Wednesday

            string dayName = dayNumber switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Invalid day" // default case
            };
            Console.WriteLine(dayName);
        }
        }
    }


