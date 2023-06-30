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
        internal int health;
        internal int energy;
        internal string name;
        internal Element weaknes;
        

        public ConsoleMon()
        {
            
        }
        internal ConsoleMon(int health, int energy, string name)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
        }
        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        private void skills() 
        { 
            List<Skill> skills= new List<Skill>();
        }

        

    }
}
