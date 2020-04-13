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
        //Fleet needs a List<Robot> as a member variable
        List<Robot> robots = new List<Robot>();
        //Declare the List up here
        Robot robo_1 = new Robot("Robo_1");
        Robot robo_2 = new Robot("Robo_2");
        Robot robo_3 = new Robot("Robo_3");

        

        //constructor (spawner)
        public Fleet()
        {
            //instantiate the List<Robot>
            
            //Instantiate 3 robots and add them to the list
            robots.Add(robo_1);
            robots.Add(robo_2);
            robots.Add(robo_3);
          

        }
        //member methods (can do)
    } 
}
