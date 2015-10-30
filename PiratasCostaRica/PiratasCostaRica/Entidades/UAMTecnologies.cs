using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratasCostaRica.Entidades
{
    //creator
    public abstract class UAMTecnologies
    {
        private Persona person;
        public Persona Person { get { return person; } set { person = value; } }


        public abstract void IngresarPersona();
        
    }
}
