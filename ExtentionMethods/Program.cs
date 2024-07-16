using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtentionMethods;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 250000;
            Console.WriteLine(price.ToToman());
            Console.ReadKey();
        }
       
    }
    public static class IntExtention 
    {
        public static string ToToman(this int Value)
        {
            return Value / 10+" Toman";
        }
    }
}
