using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass myClass1 = new MyClass();
            myClass1.aSet(15);
            Console.WriteLine(myClass1.aGet());
        }
    }
}
