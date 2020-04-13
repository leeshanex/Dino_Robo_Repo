using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Dino_Proj
{
    class Robot
    {
        //member variables (has a)
        string name;
        public int healthPoints;
        int powerLevel;
        Weapon weapon;
        int attackPower;

        //constructor (spawner)
        public Robot()
        {
            name = "TBD";
            healthPoints = 100;
            powerLevel = 5;
            weapon = new Weapon();
            attackPower = 10;
        }
        //member methods (can do)
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.healthPoints -= attackPower;
        }


    }
}
