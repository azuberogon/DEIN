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

namespace FormularioNoUsable
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CargarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string rutaImagen = openFileDialog.FileName;

                // Cargar la imagen seleccionada en el control Image
                BitmapImage imagenBitmap = new BitmapImage(new Uri(rutaImagen));
                imagenAmostrar.Source = imagenBitmap;
            }
        }

        private void txt_GotFocus(Object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "Direccion" || textBox.Text == "Ciudad" || textBox.Text == "Provincia" || textBox.Text == "Codigo Postal" || textBox.Text == "Pais")
                {
                    textBox.Text = "";
                }
            }
        }

        private void txt_LostFocus(Object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (String.IsNullOrWhiteSpace(textBox.Text))
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
                    else if (textBox.Text == "txtPostal")
                    {
                        textBox.Text = "Codigo Postal";
                    }
                    else if (textBox.Text == "txtPais")
                    {
                        textBox.Text = "Pais";
                    }
                }
            }
        }

        private void btnGuardar(object sender, RoutedEventArgs e)
        {


            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingresa un nombre valido", "Error");
            }
            else if (txtApellidos.Text == "")
            {
                MessageBox.Show("Ingresa un apellido valido", "Error");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Ingresa un email valido", "Error");
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingresa un telefono valido", "Error");
            }
            else
            {
                Empleados nuevoEmpleado = new Empleados(txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text);


                datagrid.Items.Add(nuevoEmpleado);
            }


        }

        private void btnCancelar(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaVentana = new MainWindow();
            nuevaVentana.Show();
            this.Close();
        }

        public class Empleados
        {
            public string nombre { get; set; }
            public string apellidos { get; set; }
            public string email { get; set; }
            public string telefono { get; set; }

            public Empleados(string nombre, string apellidos, string email, string telefono)
            {
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.email = email;
                this.telefono = telefono;
            }
        }
    }

}
