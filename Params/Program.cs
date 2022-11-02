using System;
using System.Linq;

namespace Params
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2,3,4,5,6,7,8,9));

        }

        static int Add(params int[] numbers)
        {
            return numbers.Sum();

          

        }

    }
}
