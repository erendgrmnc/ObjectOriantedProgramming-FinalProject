using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJECT_1._0
{
    interface IFunctions
    {
       void death(bool x);
       void Increase();
       void Sell();

        
    }

   

    abstract class Animal
    {
        public int health = 100;
        public bool isAlive = true;

        
    }
}
