using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratasCostaRica.Entidades
{
    //concretproduct
    public class Cliente:Persona
    {
        private string nombre;
        public override string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private string apellido;
        public override string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        private int edad;
        public override int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        private string telefono;
        public override string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
        private DateTime fechaingreso;
        public override DateTime Fechaingreso
        {
            get
            {
                return fechaingreso;
            }
            set
            {
                fechaingreso = value;
            }
        }


        public override void Ingresar()
        {
            throw new NotImplementedException();
        }

        public override void Actualizar()
        {
            throw new NotImplementedException();
        }

        public override void Deshabilitar()
        {
            throw new NotImplementedException();
        }
    }
}
