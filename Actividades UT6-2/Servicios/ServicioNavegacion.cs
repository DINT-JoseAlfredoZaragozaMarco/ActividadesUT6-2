using Actividades_UT6_2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Actividades_UT6_2.Servicios
{
    class ServicioNavegacion
    {
        private bool iniciada;
        private UserControl contenedorUserControlLista;

        public ServicioNavegacion()
        {
            iniciada = false;
        }

        public UserControl ObtenerNuevaPersona()
        {
            return new NuevaPersona();
        }

        public UserControl ObtenerListaPersonas()
        {
            if (!iniciada)
            {
                iniciada = true;
                contenedorUserControlLista = new ListadoPersonas();
                return contenedorUserControlLista;
            }
            else
            {
                return contenedorUserControlLista;
            }
        }
        
        public bool? AñadirNacionalidad()
        {
            AñadirNacionalidad añadirNacionalidadUserControl = new AñadirNacionalidad();
            return añadirNacionalidadUserControl.ShowDialog();
        }
    }
}
