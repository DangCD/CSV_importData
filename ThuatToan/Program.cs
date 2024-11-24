using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThuatToan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
       
            for (int i = 1; i <= t; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int total = 0;
                string[] input2 = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    int soKhach = int.Parse(input2[j]);
                    int sokeo = (m % (soKhach + 1) == 0) ? (m / (soKhach + 1)) : ((m / (soKhach + 1)) + (m % (soKhach + 1)));
                    total += sokeo;
                  
                }
                Console.WriteLine(total);


            }
            Console.ReadKey();
        }
    }
}

            
