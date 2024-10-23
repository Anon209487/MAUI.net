using System.Collections.ObjectModel;
using Ejercicio5UI.DAL;
using Ejercicio5UI.Entidades;

namespace Ejercicio5UI
{
    public partial class MainPage : ContentPage
        {
            public ObservableCollection<ClsPersona> Personas { get;}

        public MainPage()
            {
            InitializeComponent();
            Personas = ListaPersonas.ObtenerPersonas();
            BindingContext = this;
        }

        private void OnNuevoClicked(object sender, EventArgs e)
        {

        }
    }
    }

