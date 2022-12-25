class MinMaxArray
{
    public static int FindMinElement(int[] arr){
        int min=arr[0];
        for(int i =1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;
        }
    public static int FindMaxElement(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 10, 30, 20, 45, 69, 32, 11, 2, 6 };

        int min = FindMinElement(arr);
        Console.WriteLine($"Min value is: {min}");

        int max = FindMaxElement(arr);
        Console.WriteLine($"Max value is: {max}");
        
    }

}