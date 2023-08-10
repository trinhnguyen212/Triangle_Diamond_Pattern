using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 8;
            int i, j, k;
            
            for (i = 1; i <= value; i++)
            {
                for (j = 1; j <= value - i; j++)
                {
                    Console.Write(" ");
                }
                for (k =1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
            Console.ReadLine();
        }
    }
}
