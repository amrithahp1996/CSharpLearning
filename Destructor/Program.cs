class Employee
{
    public int a;
    public int b;
    public Employee(int x,int y)
    {
        a = x;
        b = y;
    }

    public void Show()
    {
        Console.WriteLine($"{a} {b}");
    }

    ~Employee()
    {
        Console.WriteLine("Destructor invoked");
    }
}

class EmployeeTest
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee(1,2);
        Employee emp1 = new Employee(3,4);

        emp.Show();
        emp.Show();

    }
}