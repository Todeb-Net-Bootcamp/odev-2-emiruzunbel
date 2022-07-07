using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationHomework
{
    public class MyClass
    {
        //Example for the Encupsulation 
        int a;

        public int aGet()
        {
            return this.a / 2;
        }
        public void aSet(int value)
        {
            if (value > 0)
            {
                this.a = value;
            }
        }




    }
}



