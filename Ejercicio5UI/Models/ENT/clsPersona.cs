using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5UI.Models.ENT
{
    /// <summary>
    /// Clase clspersona con sus atributos en publicos para ser accedidos por la lista 
    /// dejo el set por que anque no este implementada la clase sera editada en el en el fituro 
    /// </summary>
    public class ClsPersona
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; }

        /// <summary>
        /// Constructor con comprobaciones basicasno permitiendo cadena vacia o numeros negativos usa ternarias para no dejar valores nulos
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="Edad"></param>
        public ClsPersona(int Id, string Nombre, string Apellidos, int Edad)
        {
            this.Id = Id >= 0 ? Id : 0;
            this.Nombre = !string.IsNullOrWhiteSpace(Nombre) ? Nombre : "Nombre no válido";
            this.Apellidos = !string.IsNullOrWhiteSpace(Apellidos) ? Apellidos : "Apellidos no válidos";
            this.Edad = Edad >= 0 ? Edad : 0;
        }
    }

}
