namespace ModuleReview1;

class Program
{
    static void Main(string[] args)
    {
        CircleArea(7);
        TriangleArea(12, 4);
        RectangleArea(5, 6);
        SquareArea();
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
        
    }

    public static void RectangleArea(double length, double width)
    {
        Console.WriteLine($"Enter the Length of the Rectangle: {length} ");
        length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Enter the Width of Rectangle: {width}");
        width = Convert.ToDouble(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"The area of the Rectangle is: {area}");
    }

    public static double SquareArea()
    {
        Console.WriteLine("Enter measurement of side.");
        double userInput = double.Parse(Console.ReadLine());
        double side = userInput;
        double area = side * side;
        Console.WriteLine($"Area of Square with side {side} is {area} ");
        Console.ReadKey();
        return area;

    }
    


}

