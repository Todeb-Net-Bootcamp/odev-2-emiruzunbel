using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationHomework
{
    class Opel : Car
    {
        //Please check Car and Opel classes to review the example about abstract class and method override
        public override void Brake()
        {
            Console.WriteLine("Braking continues");
        }



    }
}
