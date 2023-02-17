using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace LearnBasic
{
    public delegate void SumOfNumberCallBack(int sumOfNumber);

    class Program
    {
        public static void PrintSumOfNumber(int sumOfNumber)
        {
            Console.WriteLine("Sum of number is: {0}", sumOfNumber);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number: ");
            int targetNumber = Convert.ToInt32(Console.ReadLine());
            SumOfNumberCallBack sumOfNumberCallBack = new SumOfNumberCallBack(PrintSumOfNumber);
            Number number = new Number(targetNumber, sumOfNumberCallBack);
            Thread T1 = new Thread(new ThreadStart(number.PrintSumOfNumber));
            T1.Start();
        }
    }
    class Number
    {
        int _targetNumber;
        SumOfNumberCallBack _sumOfNumberCallBack;

        public Number(int target, SumOfNumberCallBack sumOfNumberCallBack)
        {
            this._targetNumber = target;
            this._sumOfNumberCallBack = sumOfNumberCallBack;
        }
        public void PrintSumOfNumber()
        {
            int sum = 0;
            for (int i = 1; i <= _targetNumber; i++)
            {
                sum += i;
            }
            if (_sumOfNumberCallBack != null)
            {
                _sumOfNumberCallBack(sum);
            }

        }

    }
}
