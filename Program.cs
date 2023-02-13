namespace LearnBasic
{
    class Program
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });
            Employee.PromotEmployee(empList, emp => emp.Experience >= 5);
        }
    }
    delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotEmployee(List<Employee> employeesList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeesList)
            {
                if (employee.Experience >= 5)
                {
                    System.Console.WriteLine(employee.Name + " promoted");
                }
            }
        }

    }
}
