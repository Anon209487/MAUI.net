using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5UI.Entidades
{

    public class ClsPersona(int id, string nombre, string apellidos, int edad)
    {
        public int Id { get; set; } = id;
        public string Nombre { get; set; } = nombre;
        public string Apellidos { get; set; } = apellidos;
        public int Edad { get; set; } = edad;
    }

}
