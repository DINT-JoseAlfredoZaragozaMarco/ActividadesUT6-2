using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6_2.Modelo
{
    class Persona : ObservableObject
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { SetProperty(ref nombre, value); }
		}

		private int? edad;

		public int? Edad
		{
			get { return edad; }
			set { SetProperty(ref edad, value); }
		}

		private string nacionalidad;

		public string Nacionalidad
		{
			get { return nacionalidad; }
			set { SetProperty(ref nacionalidad, value); }
		}

		public Persona()
        {
			
        }

		public Persona(string nombre, string edad, string nacionalidad)
		{
			this.nombre = nombre;
			this.edad = int.Parse(edad);
			this.nacionalidad = nacionalidad;
		}

		public override string ToString()
		{
			return this.Nombre + " - " + this.Edad + " - " + this.Nacionalidad;
		}
	}
}
