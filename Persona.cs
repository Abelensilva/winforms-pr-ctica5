using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónWindow2
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Edad { get; set; }

        public string Direccion { get; set; }

        public string MostrarDatos()
        {
            return "Nombre: " + Nombre +
                "Apellido: " + Apellido +
                " Edad: " + Edad + 
                " Direccion: " + Direccion;
                


        }
    }
}
