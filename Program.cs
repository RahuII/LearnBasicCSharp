namespace LearnBasic
{
    class A{
        public virtual void print(){
            System.Console.WriteLine("Class A Implimented");
        }
    }
    class B : A{
        public override void print()
        {
            System.Console.WriteLine("Class B Overrideing Print() method");
    
        }
    }
        class C : A{
        public override void print()
        {
            System.Console.WriteLine("Class C Overrideing Print() method");
        }
    }
    class D : B, C{
                    // problem with class 
    }
    class Program{
        public static void Main(){
            D d = new D();
            d.print();
        }
    }

}
