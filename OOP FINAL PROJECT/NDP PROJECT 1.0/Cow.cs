using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace NDP_PROJECT_1._0
{
    class Cow: Animal
    {
        public int cowMilk;
        SoundPlayer cowSound = new SoundPlayer("inek.wav");
        

      public void death(bool x)
        {
            if(x == false)
            {
                
                cowSound.Play();
               
            }
            
        }

        public void Increase()
        {
            if (isAlive)
            {
                cowMilk++;
            }
                
            
        }

        public void Sell()
        {
                cowMilk--;
        }

        

    }
}
