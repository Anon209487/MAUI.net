using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5UI.DAL
{
    using System.Collections.ObjectModel;
    using Ejercicio5UI.Entidades;

    public static class ListaPersonas
    {
        public static ObservableCollection<ClsPersona> ObtenerPersonas()
        {
            return
        [
            new(1, "Juan", "Pérez", 30),
            new (2, "María", "López", 25),
            new (3, "Pedro", "Martínez", 40),
            new (4, "Ana", "García", 35),
            new (5, "José", "Rodríguez", 28),
            new (6, "Elena", "Fernández", 32),
            new (7, "Miguel", "Hernández", 45),
            new (8, "Laura", "González", 29),
            new (9, "Carlos", "Sánchez", 37),
            new (10, "Lucía", "Ramírez", 26)
        ];
        }
    }

}
