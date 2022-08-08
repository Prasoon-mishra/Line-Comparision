// C# code to compute distance
using System;

class GFG
{
    // Function to calculate distance
    static double distance(int x1, int y1, int x2, int y2)
    {
        // Calculating distance
        return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                      Math.Pow(y2 - y1, 2) * 1.0);
    }

    // Driver code
    public static void Main()
    {
        Console.WriteLine(Math.Round(distance(3, 4, 4, 3)
                                   * 100000.0) / 100000.0);
    }
}