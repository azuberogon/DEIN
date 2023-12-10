using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Lógica de interacción para AgregarEmpleado.xaml
    /// </summary>
    public partial class AgregarEmpleado : Window
    {
        public Empleado EmpleadoAActualizar { get; set; }
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Click()
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            bool esUsuario = checkBoxEsUsuario.IsChecked ?? false;
            int edad;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                AgregarEmpleadoString(nombre, apellidos, esUsuario, edad);

                Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una edad valida,", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para agregar el empleado
            AgregarEmpleadoString(txtNombre.Text, txtApellidos.Text, checkBoxEsUsuario.IsChecked ?? false, int.Parse(txtEdad.Text));

            // Mostrar la ventana ListaEmpleados actualizada
            ListaEmpleados lista = new ListaEmpleados();
            lista.Show();

            // Cerrar la ventana actual
            Close();
        }

        private void AgregarEmpleadoString(string nombre, string apellidos, bool esUsuario, int edad)
        {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString))
            {
                string consulta = "INSERT INTO EMPLEADOS (Nombre, Apellidos, EsUsuario, Edad) VALUES (@Nombre, @Apellidos, @EsUsuario, @Edad)";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@EsUsuario", esUsuario);
                    cmd.Parameters.AddWithValue("@Edad", edad);

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al agregar empleado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void Volver(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            main.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Lógica para cargar datos en la ventana, por ejemplo:
            if (EmpleadoAActualizar != null)
            {
                // Si hay un empleado para actualizar, carga sus datos en los controles de la ventana
                txtNombre.Text = EmpleadoAActualizar.Nombre;
                txtApellidos.Text = EmpleadoAActualizar.Apellidos;
                // Otros campos
            }
        }
    }
}
