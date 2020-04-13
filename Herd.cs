using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Dino_Proj
{
    class Herd
    {
        //member variables (has a)
        List<Dinosaur> dinosaurs = new List<Dinosaur>();
        Dinosaur dino_1 = new Dinosaur("Dino_1");
        Dinosaur dino_2 = new Dinosaur("Dino_2");
        Dinosaur dino_3 = new Dinosaur("Dino_3");

        

        //constructor (spawner)
        public Herd()
        {
           
            dinosaurs.Add(dino_1);
            dinosaurs.Add(dino_2);
            dinosaurs.Add(dino_3);

        }
        //member methods (can do)
    }
}
