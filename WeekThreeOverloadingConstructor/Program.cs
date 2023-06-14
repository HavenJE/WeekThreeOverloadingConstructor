
// 3.7 Overloading constructors

using System;
class Employee
{
    private int employeeNumber;
    private string employeeName;
    public int EmployeeAge { get; set; }
    public void DisplayInformation()
    {
        Console.WriteLine("Employee number: {0}", employeeNumber);
        Console.WriteLine("Employee name: {0}", employeeName);
        Console.WriteLine("Employee age: {0}", EmployeeAge);
    }
    //Constructor 1 - No parameter 
    public Employee()
    {
        employeeNumber = 999;
    }
    //Constructor 2 - 2 parameter 
    public Employee(int id, string name)
    {
        employeeNumber = id;
        employeeName = name;
        EmployeeAge = 0;
    }
    //Constructor 3 - 3 parameters 
    public Employee(int id, string name, int age)
    {
        employeeNumber = id;
        employeeName = name;
        EmployeeAge = age;
    }

    //Constructor 4 - 1 parameter 
    public Employee(string name)
    {
        employeeName = name;
    }
    public static void Main()
    {
        Employee employee1 = new Employee();
        Employee employee2 = new Employee(123, "Jane");
        Employee employee3 = new Employee(124, "Lucky");
        Employee employee4 = new Employee("Haven");
        Console.WriteLine("***** Information of employee 1 *****");
        employee1.DisplayInformation();
        Console.WriteLine("***** Information of employee 2 *****");
        employee2.DisplayInformation();
        Console.WriteLine("***** Information of employee 3 *****");
        employee3.DisplayInformation();
        Console.WriteLine("***** Information of employee 4 *****");
        employee4.DisplayInformation();
    }
}