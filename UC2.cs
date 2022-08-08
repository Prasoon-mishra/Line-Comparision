using System;

namespace measure_distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2,x3, x4 ,y1, y2, y3, y4;
            x1 = 12000d;
            x2 = 13000d;
            y1 = 11000d;
            y2 = 10000d;
            var distance1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(distance1);
            x3 = 22000d;
            x4 = 263000d;
            y3 = 371000d;
            y4 = 40000d;
            var distance2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(distance2);
            if (distance1 == distance2)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else
            {
                Console.WriteLine("Both Lines are not Equal");
            }
        }
    }
}