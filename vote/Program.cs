using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vote
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Eligible for vote");
            }
            else
            {
                Console.WriteLine("Not eligible for vote");
            }
        }
    }
}
