using Actividades_UT6_2.Servicios;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Actividades_UT6_2.VistasModelo
{
    class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion servicioNavegacion;
        private UserControl contenidorUserControl;
        public UserControl ContenidorUserControl
        { 
            get { return contenidorUserControl; }
            set { SetProperty(ref contenidorUserControl, value); }
        }

        public RelayCommand CommandNuevaPersona { get; }
        public RelayCommand CommandListaPersonas { get; }
        public RelayCommand CommandMostrarPersona { get; }

        public MainWindowVM()
        {
            servicioNavegacion = new ServicioNavegacion();
            CommandListaPersonas = new RelayCommand(ListadoPersonas);
            CommandNuevaPersona = new RelayCommand(NuevaPersona);
            CommandMostrarPersona = new RelayCommand(MostrarPersona);
        }

        public void NuevaPersona()
        {
            ContenidorUserControl = servicioNavegacion.ObtenerNuevaPersona();
        }
        public void ListadoPersonas()
        {
            ContenidorUserControl = servicioNavegacion.ObtenerListaPersonas();
        }

        public void MostrarPersona()
        {
            ContenidorUserControl = servicioNavegacion.ObtenerMostrarPersona();
        }
    }
}
