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

namespace estilos_aitor_zubero.ventanas
{
    /// <summary>
    /// Lógica de interacción para cocina.xaml
    /// </summary>
    public partial class cocina : Window
    {
        public cocina()
        {
            InitializeComponent();
        }
        private void home(object sender, RoutedEvent e) {
            MainWindow abrirMainWindow = new MainWindow();
            this.Close();
            abrirMainWindow.Show();
        }

    }
}
