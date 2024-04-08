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
        double userRad = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserRadius is:" + userRad);
        double area = Math.PI * userRad * userRad;
        Console.WriteLine("Area of Circle is:" + area);
    }

    public static void TriangleArea(double baseLength, double height)
    {
         
        Console.WriteLine($"Enter Base Length of Triangle: {baseLength} ");
         double userBaseLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("User Base Length is:" + userBaseLength);
        Console.WriteLine($"Enter Height of Triangle: {height} ");
        double userHeight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserHeight is:" + userHeight);
        double area = userBaseLength * userHeight / 2;
        Console.WriteLine("Area of Triangle is : {0}", area);
        
    }

    public static void RectangleArea(double length, double width)
    {
        Console.WriteLine($"Enter the Length of the Rectangle. {length}");
        double userLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserLength is:" + userLength);
        Console.WriteLine($"Enter the Width of Rectangle. {width}");
        double userWidth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserWidth is :" + userWidth);
        double area = userLength * userWidth;
        Console.WriteLine($"The area of the Rectangle is: {area}");
    }

    public static double SquareArea()
    {
        Console.WriteLine("Enter measurement of side.");
        double userSide = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("UserSide is:" + userSide);
        double area = userSide * userSide;
        Console.WriteLine($"Area of Square with side {userSide} is {area} ");
        Console.ReadKey();
        return area;

    }
    


}

