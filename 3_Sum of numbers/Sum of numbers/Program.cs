using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, D, E, F, G, H, I, J;
            double totalsum;
            
                Console.WriteLine("Insert ten grades from 0 to 100");
                Console.WriteLine();

                Console.Write("input grades 1  --->");
                A = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 2  --->");
                B = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 3  --->");
                C = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 4  --->");
                D = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 5  --->");
                E = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 6  --->");
                F = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 7  --->");
                G = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 8  --->");
                H = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 9  --->");
                I = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.Write("input grades 10 --->");
                J = limited.Limiter(double.Parse(Console.ReadLine()));

                Console.WriteLine();

                totalsum = limited.grades(A, B, C, D, E, F, G, H, I, J);
                Console.WriteLine("total sum of grades --------->" + totalsum);
       
                Console.ReadKey();
        }
    }
}
