namespace ModuleReview1;

class Program
{
    static void Main(string[] args)
    {
        CircleArea(7);
    }

    public static void CircleArea(double radius)
    {
        Console.WriteLine($"Enter Radius:{radius} ");
        double rad = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * rad * rad;
        Console.WriteLine("Area of Circle is:" + area);
    }
}

