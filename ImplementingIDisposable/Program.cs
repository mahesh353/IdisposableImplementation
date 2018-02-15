using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingIDisposable
{
    class Program 
    {
        static void Main(string[] args)
        {
            ClassC classc= new ClassC();
            //classc = null;
            //Console.WriteLine("Assigned null class object destruction begins");
            //GC.Collect();
            classc.Dispose();
            Console.ReadLine();
        }
    }
}
