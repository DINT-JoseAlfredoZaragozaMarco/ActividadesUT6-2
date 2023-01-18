using Actividades_UT6_2.Modelo;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6_2.Mensajeria
{
    class PersonaChangedMessage : ValueChangedMessage<Persona>
    {
        public PersonaChangedMessage(Persona value) : base(value)
        {
        }
    }
}
