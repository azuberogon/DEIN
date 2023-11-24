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
using System.Windows.Shapes;

namespace Hestia.ventanas
{
    /// <summary>
    /// Lógica de interacción para usuarios.xaml
    /// </summary>
    public partial class usuarios : Window
    {
        
        public usuarios()
        {
            InitializeComponent();
        }
        private void BtnIrAOtraVentana(object sender, RoutedEventArgs e)
        {
            AbrirOtraVentana();
        }

        private void Image_Click(object sender, MouseButtonEventArgs e)
        {
            AbrirOtraVentana();
        }

        private void AbrirOtraVentana()
        {
            MainWindow otraVentana = new MainWindow(); // Reemplaza "OtraVentana" con el nombre de tu ventana de destino
            otraVentana.Show();
            this.Hide(); // O cierra la ventana actual si es necesario
        }



    }
}
