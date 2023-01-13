using Actividades_UT6_2.Servicios;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
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
        public RelayCommand CommandAñadirNacionalidad { get; }
        public AñadirNacionalidadVM()
        {
            CommandAñadirNacionalidad = new RelayCommand(NuevaNacionalidad);
        }

        public void NuevaNacionalidad()
        {

        }
    }
}
