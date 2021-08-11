using System;
namespace CodingChallenge
{
    public class CircleDiff
    {
        public void CircleDifference()
        {
            int radius = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            double square1 = Math.Sqrt(radius * radius * 2);

            double square2 = radius * 2;

            result = (int)Math.Round(square2 * square2 - square1 * square1);
            Console.WriteLine("The Square areas Difference is "+result.ToString());
        }
    }
}
