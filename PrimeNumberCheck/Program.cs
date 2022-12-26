//class PrimeNumberCheck
//{
//    public static void CheckNumber(int num)
//    {

//        if (num == 0 && num == 1)
//        {
//            Console.WriteLine($"{num} is not a primeNumber");
//        }
//        else
//        {
//            int count = 0;
//            for(int i = 1; i <= num; i++)
//            {
//                if(num % i == 0)
//                {
//                    count++;
//                }
//            }
//            if (count == 2)
//            {
//                Console.WriteLine($"{num} is a primeNumber");
//            }
//            else
//            {
//                Console.WriteLine($"{num} is not a primeNumber");
//            }
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a number:");
//        int num = Int32.Parse(Console.ReadLine());
//        CheckNumber(num);
//    }
//}