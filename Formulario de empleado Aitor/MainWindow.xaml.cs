using Formulario_de_empleado_Aitor.Properties;
using Microsoft.Win32;
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

namespace Formulario_de_empleado_Aitor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Empleado> empleado = new List<Empleado>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btn_CargarFoto(object sender, TextChangedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == true)
            {

                string filePath = openFileDialog.FileName;
                try
                {
                    // Crear un objeto BitmapImage para mostrar la imagen.
                    BitmapImage bitmapImage = new BitmapImage(new Uri(filePath));

                    // Asignar la imagen al control Image en tu interfaz de usuario.
                    imageControl.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Txt_GotFocus(object sender, RoutedEventArgs e) {
            if (sender is TextBox textBox) {
                if (textBox.Text == "Direccion" || textBox.Text == "Ciudad" || textBox.Text == "Provincia" || textBox.Text == "Codigo Postal" || textBox.Text == "Pais") {
                    textBox.Text = "";
                }
            }
        }
        private void Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Name == "txtDireccion")
                {
                    textBox.Text = "Direccion";
                }
                else if (textBox.Name == "txtCiudad")
                {
                    textBox.Text = "Ciudad";
                }
                else if (textBox.Name == "txtProvincia")
                {
                    textBox.Text = "Provincia";
                }
                else if (textBox.Name == "txtCodigoPostal")
                {
                    textBox.Text = "Codigo Postal";
                }
                else if (textBox.Name == "txtPais")
                {
                    textBox.Text = "Pais";
                }
            }
        }

        private void botonGuardar_Click(object sender, RoutedEventArgs e)
{
    if (!string.IsNullOrWhiteSpace(Nombre.Text) &&
        !string.IsNullOrWhiteSpace(Apellido.Text) &&
        !string.IsNullOrWhiteSpace(Email.Text) &&
        !string.IsNullOrWhiteSpace(Telefono.Text))
    {
        // Crear un nuevo empleado y agregarlo a la lista
        Empleado nuevoEmpleado = new Empleado
        {
            Nombre = Nombre.Text,
            Apellidos = Apellido.Text,
            Email = Email.Text,
            Telefono = Telefono.Text
        };

        empleado.Add(nuevoEmpleado);

        // Actualizar el DataGrid
        // Limpiar los campos
        Nombre.Text = "";
        Apellido.Text = "";
        Email.Text = "";
        Telefono.Text = "";
    }
    else
    {
        MessageBox.Show("Por favor complete todos los campos.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}

    }

}
