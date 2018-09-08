using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = new int[4];
            Number[0] = 987;
            Number[1] = 654;
            Number[2] = 5451;
            Number[3] = 5645;
            foreach (int k in Number)

            {
                Console.WriteLine(k);

            }
            Console.ReadLine();
        }
    }
}
