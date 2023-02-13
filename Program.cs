namespace LearnBasic
{
    public delegate void HelloFuntionDeligates(string Message);
    class Program
    {
        public static void Main()
        {
            HelloFuntionDeligates del = new HelloFuntionDeligates(printMessage);
            del("Good afternoon rahul!");


            // another way of call delegates 
            // printMessage("Good afternoon Rahul Kumar");

        }
        public static void printMessage(string mess)
        {
            System.Console.WriteLine(mess);
        }
    }

}
