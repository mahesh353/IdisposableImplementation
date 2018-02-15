using System;

namespace ImplementingIDisposable
{
    public class ClassB : ClassA
    {
        public ClassB()
        {
            Console.WriteLine("ClassB object initialized");
        }
        ~ClassB()
        {
            Console.WriteLine("Destructing ClassB object");
        }
    }
}
