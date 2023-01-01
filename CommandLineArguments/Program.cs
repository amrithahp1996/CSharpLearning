class CommandLineArg{
    public static void Main(string[] args)
    {
        foreach(string arg in Environment.GetCommandLineArgs())
        {
            Console.WriteLine(arg);
        }
        Console.ReadKey();
    }
}