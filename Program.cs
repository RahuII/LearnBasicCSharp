namespace LearnBasic
{
    public delegate void MyCallbackDelegate(int result);
    class Program
    {

        public static void MyThreadFunction(MyCallbackDelegate callback)
        {
            // Perform some processing...

            int result = 42;

            // Call the callback method with the result
            callback(result);
        }
        public static void MyCallbackMethod(int result)
        {
            Console.WriteLine("Result from thread function: " + result);
        }

        static void Main(string[] args)
        {
            MyCallbackDelegate callback = new MyCallbackDelegate(MyCallbackMethod);
            Thread myThread = new Thread(() => MyThreadFunction(callback));
            myThread.Start();

        }
    }

}
