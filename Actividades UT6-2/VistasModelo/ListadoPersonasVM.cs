using Actividades_UT6_2.Modelo;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6_2.VistasModelo
{
    class ListadoPersonasVM : ObservableObject
    {
        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

        private string textoAMostrar;

        public string TextoAMostrar
        {
            get { return textoAMostrar; }
            set { textoAMostrar = value; }
        }


        public ListadoPersonasVM()
        {
            Personas = new ObservableCollection<Persona>();

            Personas.Add(new Persona("Pietro", 30, "Italiana"));
            Personas.Add(new Persona("Julia", 25, "Española"));
            Personas.Add(new Persona("Sophie", 35, "Francesa"));

            MostrarPersonas();
        }

        public void MostrarPersonas()
        {
            TextoAMostrar = "";
            foreach(Persona p in Personas)
            {
                TextoAMostrar = TextoAMostrar + $"{p.ToString()}\n";
            }
        }
    }
}
