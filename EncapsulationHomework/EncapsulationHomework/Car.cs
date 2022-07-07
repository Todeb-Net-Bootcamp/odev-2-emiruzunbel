using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationHomework
{
    abstract class Car
    {
        //Please check Car and Opel classes to review the example about abstract class and method override
        public int speed;
        public DateTime YearOfProduction;
        public string colour;

        public virtual void Brake()
        {
            Console.WriteLine("Braking is progress");
        }
        


    }
}
