using System;

namespace ImplementingIDisposable
{
    public class ClassC : ClassB,IDisposable
    {
        private bool disposed = false;
        public ClassC()
        {
            Console.WriteLine("ClassC object initialized");
        }
        ~ClassC()
        {
            //If user forgots to call the dispose method we are calling it from the destuctor to clean up the unmanaged resources 
            this.Dispose(false);
            Console.WriteLine("Destructing ClassC object");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //clean managed code here
                }
               
            }
            //clean unmanaged code here
            //if base class has also impleted the IDisposable interface dont forget to call using 
            //base.dispose();
            Console.WriteLine("Cleaning up code using the dispose method");
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            //means do not call the destructor/finalize logic if user is calling the dispose method manually
            GC.SuppressFinalize(this);
        }


    }
}
