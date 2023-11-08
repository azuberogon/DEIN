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
    }

}
