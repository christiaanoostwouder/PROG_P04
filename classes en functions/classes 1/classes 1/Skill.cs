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

        public Skill() 
        {

        }
        internal Skill(int damage, int energyCost, string name, Element element)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = new Element();
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
