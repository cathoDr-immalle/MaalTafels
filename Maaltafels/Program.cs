using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maaltafels
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {

                Console.WriteLine("De Maaltafels van " + i+ ":");

                for(int p = 1; p <= 10; p++ )
                {
                    Console.WriteLine(i * p);
                }

                Console.WriteLine();

            }

            Console.Read();
        }
    }
}
