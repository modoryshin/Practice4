using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4._0
{
    class Program
    {
        static double Func(int i)
        {
            return 1 / (Math.Pow(4, i) + Math.Pow(5, (i + 2)));
        }
        static double Eps()
        {
            double e;
            bool ok;
            do
            {
                Console.WriteLine("Enter epsilon.");
                ok = Double.TryParse(Console.ReadLine(), out e);
                if (!ok)
                    Console.WriteLine("Invalid data type.");
                else if (e <= 0)
                    Console.WriteLine("Epsilon must be greater then 0.");
            } while (!ok || e <= 0);
            return e;
        }
        static void Main(string[] args)
        {
            double eps = Eps();
            double sum = 0, current, previous;
            int i = 0;
            current = Func(i);
            sum += current;
            i++;
            do
            {
                previous = current;
                current = Func(i);
                sum += current;
                i++;
            } while (Math.Abs(current - previous) > eps);
            Console.WriteLine("Sum equals {0}", sum);
            Console.ReadKey();
        }
    }
}
