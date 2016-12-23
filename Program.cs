using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEx
{
    class Program
    {
        enum days{
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };
        static void Main(string[] args)
        {
            int a = (int)days.Sunday;
            int b = (int)days.Friday;
            Console.WriteLine("Sunday = {0}", a);
            Console.WriteLine("Friday = {0}", b);
            Console.ReadLine();
        }
    }
}
