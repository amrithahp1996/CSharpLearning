using System.Globalization;

class PrintNumbers
{
    public static void Main(String[] args)
    {

        //for (int i = 0; i <= 10; i++)
        //{
        //    for (int j = 0; j <= 10; j++)
        //    {
        //        Console.WriteLine($"i:{i} j:{j}");
        //    }
        //}

        //int i=0;
        //int j=0;
        //while (i <= 10)
        //{
        //    while (j <= 10)
        //    {
        //        Console.WriteLine($"i:{i} j:{j}");
        //        j++;
        //    }
        //    i++;

        //    j = 0;
        //}
        int i = 0,j=0;
        do {
            while (j<10)
            {
                Console.WriteLine($"i:{i} j:{j}");
                j++;
            }
            i++;
            j = 0;
        } while (i<=10);
    }
}