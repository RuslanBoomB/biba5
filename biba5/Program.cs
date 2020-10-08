using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Средний
            try
            {
                Console.Write("Введите N:");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0 && n % 7 == 0 && n % 13 != 0 && n % 11 != 0) Console.WriteLine("Истина");
                else Console.WriteLine("Ложь");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}