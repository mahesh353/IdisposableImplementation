using System;

namespace ImplementingIDisposable
{
    public class ClassA 
    {
        public ClassA()
        {
            Console.WriteLine("ClassA object initialized");
        }

        //Once we compile the program destructor get converted into finalize method
        ~ClassA()
        {
            Console.WriteLine("Destructing ClassA object");
        }

        
    }
}
