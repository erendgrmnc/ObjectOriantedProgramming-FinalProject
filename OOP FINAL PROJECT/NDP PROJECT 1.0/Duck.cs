using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace NDP_PROJECT_1._0
{
    class Duck:Animal
    {

        public int duckEgg;
        SoundPlayer duckSound = new SoundPlayer("ordek.wav");

        public void death(bool x)
        {
            if (x == false)
            {
                duckSound.Play();
            }
           
        }

        public void Increase()
        {
            if (isAlive == true)
            {
                duckEgg++;
            }
        }
        
        public void Sell()
        {
            duckEgg--;
        }

    }
}
