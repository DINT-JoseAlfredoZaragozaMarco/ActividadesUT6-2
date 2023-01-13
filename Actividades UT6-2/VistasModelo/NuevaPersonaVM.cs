using Actividades_UT6_2.Modelo;
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

namespace Actividades_UT6_2.VistasModelo
{
    class NuevaPersonaVM : ObservableObject
    {
        private ServicioNavegacion servicioNavegacion;
        private Window contenidoVentana;
        public Window ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }

        private ObservableCollection<string> nacionalidades;

        public ObservableCollection<string> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }

        private Persona personaNueva;

        public Persona PersonaNueva
        {
            get { return personaNueva; }
            set { SetProperty(ref personaNueva, value); }
        }


        public RelayCommand CommandAñadirNacionalidad { get; }
        public RelayCommand CommandNuevaPersona { get; }

        public NuevaPersonaVM()
        {
            servicioNavegacion = new ServicioNavegacion();
            CommandAñadirNacionalidad = new RelayCommand(AñadirNacionalidad);
            CommandNuevaPersona = new RelayCommand(AgregarNuevaPersona);
            Nacionalidades = new ObservableCollection<string>();
            PersonaNueva = new Persona();

            Nacionalidades.Add("Española");
            Nacionalidades.Add("Francesa");
            Nacionalidades.Add("Italiana");
        }

        public void AñadirNacionalidad()
        {
            ContenidoVentana = servicioNavegacion.AñadirNacionalidad();
            ContenidoVentana.ShowDialog();
        }

        public void AgregarNuevaPersona()
        {
            MessageBox.Show(PersonaNueva.ToString());
        }
    }
}