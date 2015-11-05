using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PiratasCostaRica.Procedimientos
{
    public abstract class Servicio
    {
        private string ced;
        private string cedchofer;
        private string ruta;
        private double dinero;

        public string Ced { get { return ced; } set { ced = value; } }
        public string Ruta { get { return ruta; } set { ruta = value; } }
        public double Dinero { get { return dinero; } set { dinero = value; } }
        public string Cedchofer { get { return cedchofer; } set { cedchofer = value; } }

        public abstract void SolicitarServicio() { }
    }
}
