class PropertiesExample
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value + " Shenoy";
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        PropertiesExample properties = new PropertiesExample();
        properties.Name = "Amritha";
        Console.WriteLine(properties.Name);
    }
}