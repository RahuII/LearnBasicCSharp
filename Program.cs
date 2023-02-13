namespace LearnBasic
{



    interface I1{
        void InterfaceMethod();
    }
        interface I2{
        void InterfaceMethod();
    }

    class Program : I1, I2
    {

        public static void Main(string[] args){
            Program p = new Program();
            ((I1)p).InterfaceMethod();
            ((I2)p).InterfaceMethod();
        }
        public void InterfaceMethod()
        {
            System.Console.WriteLine("I2 interface method is implimented");
        }

        void I2.InterfaceMethod()
        {
            System.Console.WriteLine("I1 Interface Method ");
        }

        
    }
}
