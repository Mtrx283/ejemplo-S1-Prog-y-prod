using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_prod_s1
{
    internal class Entity
    {
        protected string name;

        public string Name
        {
            get { return name; }
        }

        public Entity(string name) 
        {
            this.name = name;
        }
    }
}
