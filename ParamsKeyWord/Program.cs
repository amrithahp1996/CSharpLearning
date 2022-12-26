class ParamsKeyWord{

    public void ShowExample(params int[] x)  //use params keyword, it accepts SD array
    {
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine(x[i]);
        }
    }

    public void ShowExampleObj(params object[] objects) //passing as an object
    {
        for (int i =0; i< objects.Length; i++)
        {
            Console.WriteLine(objects[i]);
        }
    }

    public static void Main(string[] args)
    {
        ParamsKeyWord paramsKW = new ParamsKeyWord();
        paramsKW.ShowExample(1,2,3,4,5,6,7,8);  //can pass any no of arguments 

        paramsKW.ShowExampleObj("Amritha", "Shenoy", 26, "22/09/1996");  //passing as an object

    }
}