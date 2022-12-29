public struct Rectangle{          //struct
    public int width;
    public int height;

    public Rectangle(int width, int height) //constructor with parameters
    {
        this.width = width;
        this.height = height;
    }
    public void display()
    {
        Console.WriteLine("Area is : " + width * height);
    }
}
public class StructExample       //structs cannot be inherited it is sealed
{
    public static void Main(string[] args)
    {
        Rectangle rectangle= new Rectangle(5,5);
        rectangle.display();
    }
}