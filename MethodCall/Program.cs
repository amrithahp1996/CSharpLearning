using System.Security.Cryptography;

class MethodCall
{
    //CallByValue
    public void display(int val)
    {
        val +=val;
        Console.WriteLine(val);
    }

    //CallByReference
    public void displayRef(ref int val) 
    {
        val += val;
        Console.WriteLine(val);
    }

    //Using OUT parameter
    public void displayOut(out int val2,out int val3)
    {
        val2 = 10;
        val2 *= val2;
        Console.WriteLine(val2);

        val3 = 5;
        val3 *= val3;
        Console.WriteLine(val3);
    }

    public static void  Main(string[] args) {
        //CallByValue
        int val = 10;
        MethodCall method = new MethodCall();
        method.display(val);
        Console.WriteLine(val);

        //CallByReference
        int val1 = 20;
        method.displayRef(ref val1);
        Console.WriteLine(val1);

        //Using out parameter
        int val2;
        int val3;
        method.displayOut(out val2,out val3);
        }
}