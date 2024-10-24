using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5UI.DAL
{
    using System.Collections.ObjectModel;
    using Ejercicio5UI.Entidades;
    /// <summary>
    /// Clase Lista de personas que recoge personas y las almacenna
    /// </summary>
        public static class ListaPersonas
        {
        /// <summary>
        /// Funcion statica que almacena objetos de la clase persona 
        /// </summary>
        /// <returns>Devuelve un listado con peropsnas el ObservableCollection impide que se edite(creo) lo cambiare cuando se pida modificar el listado ya no me da tiempo a cambiarlo </returns>
        public static ObservableCollection<ClsPersona> ObtenerPersonas()
            {
                var personas = new List<ClsPersona>
            {
                new ClsPersona(1, "Juan", "Pérez", 30),
                new ClsPersona(2, "María", "López", 25),
                new ClsPersona(3, "Pedro", "Martínez", 40),
                new ClsPersona(4, "Ana", "García", 35),
                new ClsPersona(5, "José", "Rodríguez", 28),
                new ClsPersona(6, "Elena", "Fernández", 32),
                new ClsPersona(7, "Miguel", "Hernández", 45),
                new ClsPersona(8, "Laura", "González", 29),
                new ClsPersona(9, "Carlos", "Sánchez", 37),
                new ClsPersona(10, "Lucía", "Ramírez", 26)
            };

           
                return new ObservableCollection<ClsPersona>(personas);
            }
        }
    }


