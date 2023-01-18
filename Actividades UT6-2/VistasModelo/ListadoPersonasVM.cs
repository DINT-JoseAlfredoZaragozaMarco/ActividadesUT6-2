using Actividades_UT6_2.Mensajeria;
using Actividades_UT6_2.Modelo;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
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

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public ListadoPersonasVM()
        {
            Personas = new ObservableCollection<Persona>();

            Personas.Add(new Persona("Pietro", "30", "Italiana"));
            Personas.Add(new Persona("Julia", "25", "Española"));
            Personas.Add(new Persona("Sophie", "35", "Francesa"));

            WeakReferenceMessenger.Default.Register<PersonaChangedMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);
            });
        }
    }
}
