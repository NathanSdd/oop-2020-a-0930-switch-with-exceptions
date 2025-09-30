using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_2020_a_0930_switch_with_exceptions.Modules
{
    internal class ExceptionDemoDriver
    {
        public static void ExceptionDemo()
        {
            string filePath = "nonexistentfile.txt";
            try
            {
                string content = File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException\t caught:\t [ {ex.Message} ]");
            }
            finally
            {
                Console.WriteLine("This is the finally block, always executed.");
            }
        }
    }
}
