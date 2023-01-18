using Actividades_UT6_2.Mensajeria;
using Actividades_UT6_2.Servicios;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Actividades_UT6_2.VistasModelo
{
    class AñadirNacionalidadVM : ObservableObject
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public RelayCommand CommandAñadirNacionalidad { get; }
        public AñadirNacionalidadVM()
        {
            Nacionalidad = "";
            CommandAñadirNacionalidad = new RelayCommand(NuevaNacionalidad);
        }

        public void NuevaNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new NacionalidadChangedMessage(Nacionalidad));
        }
    }
}
