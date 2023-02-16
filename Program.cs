using System.Runtime.InteropServices;

namespace LearnBasic
{
    public delegate void SimpleDelegate();

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }

    public class Company
    {
        public static void Main(string[] args)
        {
            addNumber(12, 13);
        }
        public static void addNumber(int a, int b, [Optional] int c)
        {
            System.Console.WriteLine(a + b);
        }
        public static void addNumber(int a, int b, params object[] c)
        {
            int result = a + b;
            if (c != null)
            {
                foreach (int i in c)
                {
                    result += i;
                }
            }

        }
        // public static void addNumber(int a, int b, [Optional] int c)
        // {
        //     System.Console.WriteLine(a + b + c);
        // }
    }
}