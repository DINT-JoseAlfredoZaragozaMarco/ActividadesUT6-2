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
        public UserControl ObtenerNuevaPersona()
        {
            return new NuevaPersona();
        }

        public UserControl ObtenerListaPersonas()
        {
            return new ListadoPersonas();
        }
        
        public Window AñadirNacionalidad()
        {
            return new AñadirNacionalidad();
        }
    }
}
