using System.Runtime.InteropServices;

namespace LearnBasic
{
    class LINQ
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 67, 45, 4, 64, 45 };

            var query = from number in numbers where number > 5 orderby number descending select number;

            foreach (var i in query)
            {
                System.Console.WriteLine(i);
            }
        }
    }
    
}