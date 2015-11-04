using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratasCostaRica.Entidades
{
    //product
    public abstract class Persona
    {
        public abstract string Nombre {get; set;}
        public abstract string Apellido { get; set; }
        public abstract string Telefono { get; set; }
        public abstract int Edad { get; set; }
        public abstract DateTime Fechaingreso { get; set; }

        public abstract void Ingresar();
        public abstract void Actualizar();
        public abstract void Deshabilitar();
    }
}
