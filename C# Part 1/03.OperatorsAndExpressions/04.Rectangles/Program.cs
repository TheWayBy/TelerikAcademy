using System;

namespace Rectangles
{
    public class Program
    {
        public static void Main()
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float perimeter = 2 * width + 2 * height;
            float area = width * height;
            Console.WriteLine("Perimeter is: {0}, Area is: {1}", perimeter, area);
            Console.ReadLine();
            
        }
    }
}
