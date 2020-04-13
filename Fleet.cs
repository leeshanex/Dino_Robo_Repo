using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Dino_Proj
{
    class Fleet
    {
        //member variables (has a)
        public int LifeSteal;
        //constructor (spawner)
        public Fleet(Dinosaur dinosaur)
        {
            LifeSteal = dinosaur.healthPoints += 5;
        }
        //member methods (can do)
        public void 
    }
}
