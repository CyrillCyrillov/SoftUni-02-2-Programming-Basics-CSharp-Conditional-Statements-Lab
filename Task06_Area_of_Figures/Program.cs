using System;

namespace Task06_Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine(area);
            }
            if (figure == "rectangle")
            {
                double lenht = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double area = lenht * width;
                Console.WriteLine(area);
            }
            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine(area);
            }
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = side * height / 2;
                Console.WriteLine(area);
            }
        }
    }
}
