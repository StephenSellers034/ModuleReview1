namespace ModuleReview1;

class Program
{
    static void Main(string[] args)
    {
        CircleArea(7);
        TriangleArea(12, 4);
    }

    public static void CircleArea(double radius)
    {
        Console.WriteLine($"Enter Radius:{radius} ");
        double rad = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * rad * rad;
        Console.WriteLine("Area of Circle is:" + area);
    }

    public static void TriangleArea(double baseLength, double height)
    {
         
        Console.WriteLine($"Enter Base Length of Triangle: {baseLength} ");
        baseLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Enter Height of Triangle: {height} ");
        height = Convert.ToDouble(Console.ReadLine());
        double area = baseLength * height / 2;
        Console.WriteLine("Area of Triangle is : {0}", area);
        Console.ReadLine();
    }


}

