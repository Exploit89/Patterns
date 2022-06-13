using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 1; 1 < 100; i += 1)
            {
                if (i % 10 == 0)
                    break;
                if (i % 3 == 0)
                    continue;

                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);

        }
    }
}
