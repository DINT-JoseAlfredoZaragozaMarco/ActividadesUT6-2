﻿using Actividades_UT6_2.VistasModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Actividades_UT6_2.Vistas
{
    /// <summary>
    /// Lógica de interacción para ListadoPersonas.xaml
    /// </summary>
    public partial class ListadoPersonas : UserControl
    {
        private ListadoPersonasVM vm;
        public ListadoPersonas()
        {
            InitializeComponent();
            vm = new ListadoPersonasVM();
            this.DataContext = vm;
        }
    }
}
