class ArrayExample
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        arr[0] = 1;
        arr[3] = 5;
        arr[4] = 6;

        foreach(int a in arr)
        {
            Console.WriteLine(a);
        }

        int[] arr2 = new int[4] { 1, 2, 3 ,4};

        int[] arr3 = {2,4,6,8,10};
        for(int i = 0; i < arr3.Length; i++)
        {
            Console.WriteLine(arr3[i]);
        }
    }
}