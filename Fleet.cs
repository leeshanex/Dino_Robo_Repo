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
        //Declare the List up here
        List<string> robots = new List<string>();

        //constructor (spawner)
        public Fleet()
        {
            //instantiate the List<Robot>
            //Instantiate 3 robots and add them to the list
            robots.Add("Robo_1");
            robots.Add("Robo_2");
            robots.Add("Robo_3");

        }
        
        
        //member methods (can do)
       
}
