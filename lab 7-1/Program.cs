using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba4
{
    class Program
    {
        public struct Triangle
        {
            public double a, b, c;
            public double Square()
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }
        static void Main()
        {
            Triangle[] triagles = new Triangle[2];
            for (int i = 0; i < triagles.Length; i++)
            {
                Console.WriteLine("Введите длины (a,b,c) сторон треугольника {0}", i + 1);
                triagles[i].a = double.Parse(Console.ReadLine());
                triagles[i].b = double.Parse(Console.ReadLine());
                triagles[i].c = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < triagles.Length; i++)
            {
                Console.WriteLine("Площадь {0}-го треугольника = {1}", i + 1, triagles[i].Square());
            }
            int maxSquaredTriIdx = 0;
            for (int i = 1; i < triagles.Length; i++)
            {
                if (triagles[i].Square() > triagles[maxSquaredTriIdx].Square())
                    maxSquaredTriIdx = i;
            }
            Console.WriteLine("Макс площадь у{0}-го треугольника", maxSquaredTriIdx + 1);

            Console.ReadKey();
        }
    }
}