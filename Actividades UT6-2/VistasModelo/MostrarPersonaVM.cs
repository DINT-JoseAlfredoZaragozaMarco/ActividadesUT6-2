using Actividades_UT6_2.Mensajeria;
using Actividades_UT6_2.Modelo;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6_2.VistasModelo
{
    class MostrarPersonaVM : ObservableObject
    {
        private Persona personaActual;

        public Persona PersonaActual
        {
            get { return personaActual; }
            set { SetProperty(ref personaActual, value); }
        }

        public MostrarPersonaVM()
        {
            PersonaActual = WeakReferenceMessenger.Default.Send<PersonaRequestMessage>();
        }
    }
}
