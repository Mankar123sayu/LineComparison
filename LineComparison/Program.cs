using System;

namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Enter the value if x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value if x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value if y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value if y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Calculation lengthCal = new Calculation(x1, y1, x2, y2);
            lengthCal.Length();
        }

    }
}
