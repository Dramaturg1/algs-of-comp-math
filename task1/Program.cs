using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] values = { 1, 5, 10, 15, 20, 25, -1, -5, -10, -15, -20, -25 };

            foreach (float x in values)
            {
                float expResult = CalculateExp(x);
                float libraryExp = (float)Math.Exp(x);

                Console.WriteLine($"X = {x}");
                Console.WriteLine($"Calculated exp(x) = {expResult}");
                Console.WriteLine($"Library exp(x) = {libraryExp}");
                Console.WriteLine($"Difference = {Math.Abs(expResult - libraryExp)}");
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        static float CalculateExp(float x)
        {
            if (x < 0)
            {
                return 1.0f / CalculateExp(-x);
            }

            float sum = 1.0f;
            float term = 1.0f;
            int i = 1;

            while (true)
            {
                term *= x / i;
                if (sum + term == sum)
                {
                    break;
                }
                sum += term;
                i++;
            }

            return sum;
        }
    }
}
