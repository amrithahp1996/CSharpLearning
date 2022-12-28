class AccountDetails
{
    public int accNo;
    public string name;                 
    public static float rateOfInterest = 8;    //Static field in non-static class
    public static int count=0;
    public static int ratePercent;

    public AccountDetails(int accNo, string name) //Constructor 
    {
        this.accNo = accNo;
        this.name = name;
        count++;
    }

    static AccountDetails() //Static constructor
    {
         ratePercent = 10;
    }

    public void Details() 
    {
        Console.WriteLine($"Account details are: {accNo} {name} {rateOfInterest} {ratePercent}");
    }
}

public static class Cube       //Static class
{
   public static int CalcCube(int num) //Static class can have only Static members
    {
     return num * num * num;
    }
}
class Acount
{
    public static void Main(string[] args)
    {
        AccountDetails accountDetails = new AccountDetails(1,"ABCD");
        AccountDetails accountDetails2 = new AccountDetails(2, "EFGH");

        accountDetails.Details();
        accountDetails2.Details();

        Console.WriteLine("Total object count: " + AccountDetails.count);//Accessing static field

        int num = 3;
        Console.WriteLine($"Cube of {num} is: " + Cube.CalcCube(num));//Accessing static method using class name
    }
}