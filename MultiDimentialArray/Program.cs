class MultiDimentionalArray
{
    public static void printArray(int[,] arr)
    {
        for (int i=0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];
        arr[0, 1] = 12;
        arr[1,2]= 15;
        arr[2, 2] = 30;

        MultiDimentionalArray.printArray(arr);
    }
}