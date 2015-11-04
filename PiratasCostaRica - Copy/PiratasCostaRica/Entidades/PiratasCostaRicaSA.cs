using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratasCostaRica.Entidades
{
    //concretcreator
    public class PiratasCostaRicaSA : UAMTecnologies
    {
        public PiratasCostaRicaSA()
        {
            this.IngresarPersona();
        }


        public override void IngresarPersona()
        {
            this.Person = new Cliente();
        }
    }
}
