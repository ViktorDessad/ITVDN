namespace _006_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            //UpCast
            BaseClass baseClass = derivedClass;
            baseClass.Method();
            System.Console.WriteLine(baseClass.Method1());
            
            //DownCast
            DerivedClass derivedClass1 = (DerivedClass)baseClass;
            derivedClass1.Method();
            System.Console.WriteLine(derivedClass1.Method1());

            BaseClass baseClass1 = new BaseClass();
            baseClass1.Method();


            

        }
    }
}
