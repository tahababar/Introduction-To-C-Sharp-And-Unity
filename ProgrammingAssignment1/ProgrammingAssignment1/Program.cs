using System;

namespace ProgrammingAssignment1
{ /// <summary>
  /// The assignment provides with the distance between two points as well as
  /// the angle between two points.
  /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the application. You can calculate the distance between two points and the angle between those points.");
            Console.Write("Enter first x value: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Enter first y value: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.Write("Enter second x value: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Enter second y value: ");

            float point2Y = float.Parse(Console.ReadLine());
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;
            float x = (float)Math.Pow(deltaX, 2);
            float y = (float)Math.Pow(deltaY, 2);
            float sum = x + y;
            float distance = (float)Math.Sqrt(sum);
            float value = (float)Math.Atan2(deltaX, deltaY);
            float angle = (float)(value * (180 / Math.PI));

            Console.WriteLine("The distance between the two points is: " + distance + ".");
            Console.WriteLine("The angle between the two points is: " + angle + ".");



        }
    }
}
