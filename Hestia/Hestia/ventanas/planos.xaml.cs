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
    /// Lógica de interacción para planos.xaml
    /// </summary>
    public partial class planos : Window
    {
        public planos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            if (sender is Rectangle)
            {
                Rectangle rectangle = (Rectangle)sender;

                // Verifica si el color actual es transparente
                if (rectangle.Fill == Brushes.Transparent)
                {
                    // Cambia el color y la opacidad según tus preferencias (en este caso, verde claro)
                    rectangle.Fill = new SolidColorBrush(Color.FromArgb(255, 144, 238, 144)); // Valores RGB para verde claro
                    rectangle.Opacity = 0.5; // Ajusta la opacidad según tus necesidades
                }
                else
                {
                    // Si el color no es transparente, establece el color a transparente
                    rectangle.Fill = Brushes.Transparent;
                }
            }
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
