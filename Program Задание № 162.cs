using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program162
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Размер (XS, S, M, L, XL, XXL): ");
            string  size = Console.ReadLine()?.Trim().ToUpper();
            int rusSize;

            switch (size)
            {
                case "XS": rusSize = 42; break;
                case "S": rusSize = 44; break;
                case "M": rusSize = 46; break;
                case "L": rusSize = 48; break;
                case "XL": rusSize = 50; break;
                case "XXL": rusSize = 52; break;
                default:
                    Console.WriteLine("Неизвестный размер.");
                    return;
            }

            Console.WriteLine($"Российский размер: {rusSize}");
        }
    }
}
