using System.Collections.ObjectModel;
using Ejercicio5UI.DAL;
using Ejercicio5UI.Entidades;

namespace Ejercicio5UI
{
    public partial class MainPage : ContentPage
        {/// <summary>
         /// solo hacemos el get de persona para que estas no puedan seteadas por becarios  ademas el ReadOnlyObservableCollection no permite ediar colecciones (Lo he tenido que buscar por supuesrto)
         /// para editarlo crearia un nuevo objeto y eliminaria el anterior a traves de otra clase
         /// </summary>
        public ReadOnlyObservableCollection<ClsPersona> Personas { get;}
        /// <summary>
        /// main que llama a la lista de personas 
        /// </summary>
            public MainPage()
                {

                InitializeComponent();
                var listaPersonas = ListaPersonas.ObtenerPersonas();
                Personas = new ReadOnlyObservableCollection<ClsPersona>(listaPersonas);
                BindingContext = this;
            }
            /// <summary>
            /// funcion Boton on clicked creado para el boton add en el mainpage c# no implkementa nada 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void OnNuevoClickedNew(object sender, EventArgs e)
            {
                //por implemtatr
            }
            /// <summary>
            /// funcion Boton on clicked creado para el boton Delete en el mainpage c# no implkementa nada 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void OnNuevoClickedDelete(object sender, EventArgs e)
            {
                //por implemtatr
            }
            /// <summary>
            /// funcion Boton on clicked creado para el boton Edit en el mainpage c# no implkementa nada 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void OnNuevoClickedEdit(object sender, EventArgs e)
            {
                //por implemtatr
            }
    }
    }

