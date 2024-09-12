using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double epsilon = 1.0;

            while (1.0 + epsilon != 1.0)
            {
                epsilon /= 2.0;
            }

            epsilon *= 2.0;

            Console.WriteLine("Machine epsilon (double precision): " + epsilon);

            float epsilonSingle = 1.0f;
            while (1.0f + epsilonSingle != 1.0f)
            {
                epsilonSingle /= 2.0f;
            }
            epsilonSingle *= 2.0f;

            Console.WriteLine("Machine epsilon (single precision): " + epsilonSingle);
            Console.ReadLine();
        }
    }
}
