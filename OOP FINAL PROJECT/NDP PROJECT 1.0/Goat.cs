using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace NDP_PROJECT_1._0
{
    class Goat:Animal
    {
        SoundPlayer goatSound = new SoundPlayer("keci.wav");
        public int goatMilk;

        public void death(bool x)
        {
            if (x == false)
            {
                goatSound.Play();
            }
           
        }

        public void Increase()
        {
            if (isAlive)
            {
                goatMilk++;
            }
        }

        public void Sell()
        {
            goatMilk--;
        }
    }
}
