using System.Collections.ObjectModel;
using Ejercicio5Entidades;

namespace Ejercicio5UI
    {
        public partial class MainPage : ContentPage
        {
            public ObservableCollection<clsPersona> Personas { get; set; }

            public MainPage()
            {
                InitializeComponent();
                Personas = new ObservableCollection<clsPersona>
            {
                new clsPersona(1, "Juan", "Pérez", 30),
                new clsPersona(2, "María", "López", 25),
                new clsPersona(3, "Pedro", "Martínez", 40),
                new clsPersona(4, "Ana", "García", 35),
                new clsPersona(5, "José", "Rodríguez", 28),
                new clsPersona(6, "Elena", "Fernández", 32),
                new clsPersona(7, "Miguel", "Hernández", 45),
                new clsPersona(8, "Laura", "González", 29),
                new clsPersona(9, "Carlos", "Sánchez", 37),
                new clsPersona(10, "Lucía", "Ramírez", 26)
            };

                BindingContext = this;
            }

            private void OnNuevoClicked(object sender, EventArgs e)
            {
               
            }
        }
    }

