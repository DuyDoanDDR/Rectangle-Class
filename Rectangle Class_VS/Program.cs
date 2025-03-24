
public class Rectangle
{
    double width;
    double height;

    public Rectangle()
    {

    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double GetArea()
    {
        return this.width * this.height;
    }
    public double GetPerimeter()
    {
        return (this.width + this.height)*2;
    }
    public string Display()
    {
        return "Rectangle{" + "width = " + width + ", height = " + height + "}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);

        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
        Console.WriteLine("Rectangle Perimeter : " + rectangle.GetPerimeter());
        Console.WriteLine("Display: " + rectangle.Display());
    }
    
}



