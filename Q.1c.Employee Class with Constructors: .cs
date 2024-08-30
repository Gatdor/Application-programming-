using System;

class Employee
{
    public string Name { get; private set; }
    public int ID { get; private set; }
    public string Department { get; private set; }
    public double Salary { get; private set; }

    // Default constructor
    public Employee()
    {
        Name = "Unknown";
        ID = 0;
        Department = "Unknown";
        Salary = 0;
    }

    // Overloaded constructor
    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
        Department = "Unknown";
        Salary = 0;
    }

    // Overloaded constructor with optional parameters
    public Employee(string name, int id, string department = "Unknown", double salary = 0)
    {
        Name = name;
        ID = id;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        // Using default constructor
        Employee emp1 = new Employee();
        Console.WriteLine($"Employee 1: {emp1.Name}, ID: {emp1.ID}, Dept: {emp1.Department}, Salary: {emp1.Salary}");

        // Using constructor with name and ID
        Employee emp2 = new Employee("John Doe", 12345);
        Console.WriteLine($"Employee 2: {emp2.Name}, ID: {emp2.ID}, Dept: {emp2.Department}, Salary: {emp2.Salary}");

        // Using constructor with all parameters
        Employee emp3 = new Employee("Jane Smith", 67890, "Finance", 55000);
        Console.WriteLine($"Employee 3: {emp3.Name}, ID: {emp3.ID}, Dept: {emp3.Department}, Salary: {emp3.Salary}");
    }
}
