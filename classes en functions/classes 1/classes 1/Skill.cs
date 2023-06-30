using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_1
{
    internal class Skill
    {
        public int damage;
        public int energyCost;
        public string name;
        public Element element;

        internal Skill() 
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
            if(target.weakness == element)
            {
                target.TakeDamage(damage / 2);
            }
            target.TakeDamage(damage);
        }

        
    }
}
