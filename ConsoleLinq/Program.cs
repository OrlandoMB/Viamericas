using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{
    class Program
    {
        private static ArrayQuery _arrayQuery = new ArrayQuery();

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Values Linq Query");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            
            var _values = _arrayQuery.GreaterValues(2);

            Console.WriteLine("Greater Values: {0}", string.Join(",",_values));


            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();

        }
    }
}
