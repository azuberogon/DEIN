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

        private void BtnAjustas(object sender, RoutedEventArgs e)
        {
            ajustes ajustes = new ajustes();
            ajustes.Show();
            this.Hide();
        }

        private void btnConsumo(object sender, RoutedEventArgs e)
        {
            consumo plan = new consumo();
            plan.Show();
            this.Hide();
        }

        private void btnlimpieza(object sender, RoutedEventArgs e)
        {
            planos plan = new planos();
            plan.Show();
            this.Hide();
        }

        private void BtnMuscia(object sender, RoutedEventArgs e)
        {
            musica plan = new musica();
            plan.Show();
            this.Hide();
        }

        private void BtnCocina(object sender, RoutedEventArgs e)
        {
            cocina plan = new cocina();
            plan.Show();
            this.Hide();
        }

        private void BtnClimatizador(object sender, RoutedEventArgs e)
        {
            climatizacion plan = new climatizacion();
            plan.Show();
            this.Hide();
        }

        private void btnTV(object sender, RoutedEventArgs e)
        {
            teles plan = new teles();
            plan.Show();
            this.Hide();
        }

        private void BtnHome(object sender, RoutedEventArgs e)
        {
            casas plan = new casas();
            plan.Show();
            this.Hide();
        }

        private void BtnCamaras(object sender, RoutedEventArgs e)
        {
            camaras plan = new camaras();
            plan.Show();
            this.Hide();
        }
    }
}
