using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_prod_s1
{
    internal class Character : Entity
    {
        /*protected string name;*/
        protected int health;

        /*public string Name
        {
            get { return name; }
        }*/

        public int Health
        {
            get { return health; }
        }

        public Character(string name, int health) : base(name) 
        {
            /*this.name = name;*/
            this.health = health;
        }
    }
}
