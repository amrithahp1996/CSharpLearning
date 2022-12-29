public class EnumEample
{
    public enum Days   //A group of constants which are readonly in nature
    {
        Sunday,           //Default index value is 0
        Monday,
        Tuesday,
        Wednesday,
        Thursday, 
        Friday,
        Saturday    
    }
    
    public enum Season
    {
        Winter = 10,      //Can change the default index value 0 to any other value
        Summer,
        Spring
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Finding index of constants of Enum");
        int x = (int)Days.Sunday;
        Console.WriteLine("Index of Sunday is {0}", x);  //output  0

        int y = (int)Season.Summer;
        Console.WriteLine("Index of Summer is {0}", y);   //output  11

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Iterating an Enum with GetNames method");

        foreach (string day in Enum.GetNames(typeof(Days)))
        {
            Console.WriteLine(day);
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Iterating an Enum with GetValues method");

        foreach(Days day in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(day);
        }
    }  
}  