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
using Hestia.ventanas;

namespace Hestia
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

        private void Btn_Ajustas(object sender, RoutedEventArgs e)
        {
            ajustes ajustes = new ajustes();
            ajustes.Show();
        }

        

        private void Button_home_2(object sender, RoutedEventArgs e)
        {

        }

        private void consumo(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnlimpieza(object sender, RoutedEventArgs e)
        {
            planos plan = new planos();
            plan.Show();
        }

        private void Btn_Muscia(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Cocina(object sender, RoutedEventArgs e)
        {

        }

        private void btnConsumo(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCocina(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClimatizador(object sender, RoutedEventArgs e)
        {

        }

        private void btnTV(object sender, RoutedEventArgs e)
        {

        }

        private void BtnHome(object sender, RoutedEventArgs e)
        {

        }
    }
}
