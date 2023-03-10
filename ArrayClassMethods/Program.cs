class ArrayClassMethods { 

    public static void PrintArray(int[] arr)
    {
        foreach(var a in arr)
        {
            Console.Write(a + " ");
        }
        Console.WriteLine();
    }

    public static void Main(String[] args) {
        int[] arr = {68, 2, 4, 5, 2, 7, 9, 45, 32, 56, 22, 14 };

        //Sort an array
        Array.Sort(arr);
        Console.WriteLine("Sorted array:");
        PrintArray(arr);

        int x =  Array.BinarySearch(arr, 2); //Array must be sorted before using BinarySearch
        if (x < 0)
        {
            Console.WriteLine("BinarySearch element not found");
        }
        else
        {
            Console.WriteLine($"BinarySearch element found index is: {x}");
        }

        //Reverse an array
        Array.Reverse(arr);
        Console.WriteLine("Reversed array");
        PrintArray(arr);

        //Find index of an element
        Console.WriteLine("Index of element 45 is: "+ Array.IndexOf(arr, 45));

        //Length of an array
        Console.WriteLine("Length of the array: " + arr.Length);

        //Coping arr to empty arr2 
        int[] arr2 = new int[12];  //Creating an empty array need to specify size
        Array.Copy(arr, arr2, arr.Length);
        Console.WriteLine("Copied array arr2 is: ");
        PrintArray(arr2);

        Array.Clear(arr);
        PrintArray(arr);  // 0 0 is returned empty array with no data.

       // arr.CopyTo()
    }
}