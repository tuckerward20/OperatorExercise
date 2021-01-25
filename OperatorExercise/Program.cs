using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division(17, 4);
            //AreaOfCircle();
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);

        }
        // Step 1 division Method
        static public void Division(int a, int b)
        {
            int quotient;
            int remainder;

            quotient = a / b;

            remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} with remainder {remainder}");
        }
        static public double AreaOfCircle()
        {

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double areaCircle = Math.PI * (radius * radius);
            Console.WriteLine($"The area of a circle with radius {radius} is {areaCircle}");
            return areaCircle;

        }

    }
}
