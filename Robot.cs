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
        public string name;
        public int healthPoints;
        int powerLevel;
        Weapon weapon;
        int attackPower;

        //constructor (spawner)
        public Robot(string name)
        {
            name = "Master Robo";
            this.name = name;
            healthPoints = 70;
            powerLevel = 5;
            weapon = new Weapon();
            attackPower = 20;

        }
        //member methods (can do)
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.healthPoints -= attackPower;
            powerLevel -= 1;
            if(powerLevel == 0)
            {
                attackPower = 0;
            }
            else
            {

            }
        }
    }
}
