class JaggedArrays
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[2][];
        arr[0] = new int[] { 1, 4, 2, 6 };
        arr[1] = new int[] {3,4,5,5,6};

        for(int i=0; i<arr.Length; i++)
        {
            for(int j=0; j < arr[i].Length; j++)
            {
                Console.Write($"{arr[i][j]} ");
            }
            Console.WriteLine();
        }


    }
}