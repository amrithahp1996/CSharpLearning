class EmployeeDetails
{
    public int id;
    public string name;
    public int age;
    public float salary;

    public EmployeeDetails(int i,string n,float s ,int a) //Parameterized constructor
    {
        id = i;
        name = n;
        age = a;
        salary = s;
    }

    public void display()
    {
        Console.WriteLine($"Emplyee details: {id} {name} {age} {salary}");
    }
}
class Employee
{
    public static void Main(String[] args)
    {
        EmployeeDetails employee1 = new EmployeeDetails(1,"ABC",500000,26);
        EmployeeDetails employee2 = new EmployeeDetails(2, "DEF", 600000, 27);

        employee1.display();
        employee2.display();
    }
}