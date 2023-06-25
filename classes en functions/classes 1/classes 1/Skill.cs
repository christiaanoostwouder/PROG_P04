using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_1
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;
        internal Element element;

        public Skill() 
        {

        }
        internal Skill(int damage, int energyCost, string name)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
        }

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            if(target.weaknes == element)
            {
                target.TakeDamage(damage / 2);
            }
            target.TakeDamage(damage);
        }

        
    }
}
