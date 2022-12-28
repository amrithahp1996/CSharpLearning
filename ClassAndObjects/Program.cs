class EmployeeDetails
{
    public int id;               //fields/instance variable/data member
    public string name;
    public float salary;

    public void insert(int i,string n,float s)  //Initializing using method
    {
        id = i;
        name = n;
        salary = s;
    }

    public void display()
    {
        Console.WriteLine($"Employee details: {id}  {name} {salary}");
    }
}

class Employess
{
    public static void Main(string[] args)
    {
        EmployeeDetails details = new EmployeeDetails();  //Object created
        details.insert(1, "A", 50000);       //accessing methods in the class using objects
        details.display();
        details.insert(2, "B", 60000);
        details.display();
       
    }
}