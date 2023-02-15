namespace LearnBasic
{
    public delegate void SimpleDelegate();
    class Program
    {
        public static void Main()
        {
            SimpleDelegate del1, del2, del3;
            del1 = new SimpleDelegate(simpleMethodOne);
            del2 = new SimpleDelegate(simpleMethodTwo);
            del3 = new SimpleDelegate(simpleMethodThree);
        }


        public static void simpleMethodOne()
        {
            Console.WriteLine("SimpleMethodOne invoked ");
        }
        public static void simpleMethodTwo()
        {
            Console.WriteLine("SimpleMethodTwo invoked ");
        }
        public static void simpleMethodThree()
        {
            Console.WriteLine("SimpleMethodThree invoked ");
        }

    }
}