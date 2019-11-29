using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace NDP_PROJECT_1._0
{
    class Chicken:Animal
    {
        SoundPlayer chickenSound = new SoundPlayer("tavuk.wav");
        public int chickenEgg = 0;
        
        public void death(bool x)
        {
            if (x == false)
            {
                chickenSound.Play();
            }
           
        }
        public void Increase()
        {
            if (isAlive == true)
            {
               chickenEgg++;
            }
        }

        public void Sell()
        {
            chickenEgg--;

        }
    }
}
