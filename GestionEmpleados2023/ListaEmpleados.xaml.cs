﻿using System;
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
using System.Windows.Shapes;

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para ListaEmpleados.xaml
    /// </summary>
    public partial class ListaEmpleados : Window
    {
        private MainWindow gestionEmpleados;
        public ListaEmpleados()
        {
            InitializeComponent();
            gestionEmpleados = new MainWindow();
           
        }

        private void CargarEmpleadosEnDataGrid() {
            List<MainWindow.Empleado> empleados = gestionEmpleados.obten
        }
    }
}
