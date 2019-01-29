using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 1; t <= T; t++)
            {
                Int32 sum = 0;
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                Int32 num = Int32.Parse(space[0]);
                sum = (num * (num + 1)) / 2;
                Int32 result = (int)Math.Pow(sum, 2);
                Console.WriteLine($"Case {t}: {result}");
            }
        }
    }
}
