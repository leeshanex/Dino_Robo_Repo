using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Dino_Proj
{
    class Weapon
    {
        //member variables (has a)
        List<Robot> weaponType = new List<Robot>();
        Robot claw = new Robot("Claw");

        //constructor (spawner)
        public Weapon()
        {
            weaponType.Add(claw);
        }
        //member methods (can do)


    }
}
