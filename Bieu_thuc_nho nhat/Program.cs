using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bieu_thuc_nho_nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t =int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int total = 0;
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    total+= int.Parse(s[j]);
                }
                int x = ((total / n)<=);
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
