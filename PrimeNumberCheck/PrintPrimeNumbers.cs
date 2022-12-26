class PrintPrimeNumbers
    {

    public static int getUserInput()
    {
        Console.WriteLine("Enter a range upto which prime number need to print");
        return Int32.Parse(Console.ReadLine());
    }

    public static bool checkNumberIsPrimeorNot(int num)
    {
        bool IsPrime = true;

        for (int i = 0; i <= num;i++)
        {
            if(i==0 && i == 1)
            {
                IsPrime = false;
            }
            else
            {
                if(i == 2  || i == 3 || i == 5){
                    IsPrime = true;
                 }
                else if (i% 2 ==0 || i%3 ==0 || i%5 == 0)
                {
                    IsPrime = false;
                }
            }
        }
        return IsPrime;
    }

    public static void Main(String[] args)
    {
        int n = getUserInput();

        for (var range = 0; range <= n; range++)
        {
            if (checkNumberIsPrimeorNot(range))
            {
                Console.WriteLine($"Number {range} is PrimeNumber");
            }
            else
            {
                Console.WriteLine($"Number {range} is not a PrimeNumber");
            }
        }

        
    }
    }

