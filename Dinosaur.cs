using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Dino_Proj
{
    class Dinosaur
    {
        //member variables (has a)
        string dinoType;
        public int healthPoints;
        int energyLevel;
        int attackPower;

        //constructor (spawner)
        public Dinosaur()
        {
            dinoType = "TBD";
            healthPoints = 100;
            energyLevel = 5;
            attackPower = 10;

        }

        //member methods (can do)
        public void Attack(Robot robot)
        {
            robot.healthPoints -= attackPower;
        }
    }
}
