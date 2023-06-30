using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace classes_1
{
    internal class ConsoleMon
    {
        public int health;
        public int energy;
        public string name;
        public Element weakness;      
       
        
        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        internal void skills() 
        { 
            List<Skill> skills= new List<Skill>();
        }

        public ConsoleMon()
        {

        }

        internal ConsoleMon(int energy, int health, string name, Element weakness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
            this.weakness = weakness;
         }
        

    }
}
