class SwitchStatement
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thurday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
             default:
                Console.WriteLine("Invalid user input");
                break;
        }
    }

}