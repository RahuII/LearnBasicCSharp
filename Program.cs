using System;
   public class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];
        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTime();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}
public class Employee
{
    public string FirstName = "Rahul ";
    public string lastName = "Kumar";

    public virtual void PrintFullName() { 
        Console.WriteLine(FirstName+lastName);
    }
}
public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + lastName+" Part Time");
    }
}
public class FullTime : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + lastName+ " Full time");
    }
}

