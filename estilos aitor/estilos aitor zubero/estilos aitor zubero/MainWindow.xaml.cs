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
using estilos_aitor_zubero.ventanas;


namespace estilos_aitor_zubero
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

        private void Btn_Cocina(object sender, RoutedEventArgs e){
            cocina AbrirVentana_Cocina = new cocina();
            this.Close();
            AbrirVentana_Cocina.Show();
        
        }
        private void Btn_Ajustas(object sender, RoutedEventArgs e) {
            ajustes abrir_AJustes = new ajustes();
            this.Close();
            abrir_AJustes.Show();
        }
        private void Btn_Muscia(object sender, RoutedEventArgs e)
        {
            Musica abrir_Musica = new Musica();
            this.Close();
            abrir_Musica.Show();
        }

        private void btn_salir(object sender, RoutedEventArgs e) {
            System.Windows.Application.Current.Shutdown();
        }

        
    }
}
