class EmployeeDetails
{
    public int id;
    public string name;
    public int age;
    public float salary;

    public EmployeeDetails(int id, string name,int age, float salary)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public void display()
    {
        Console.WriteLine($"Employee ID: {id}, Name: {name}, Age: {age}, Salary: {salary}");
    }
}
class Employee
{
    public static void Main(string[] args)
    {
        EmployeeDetails employee = new EmployeeDetails(1,"Amritha",26,5000);
        employee.display();

    }
}