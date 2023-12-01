using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionEmpleados2023
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
        public class Empleado { 
            public String Nombre { get; set; }
            public String Apellido { get; set; }
            public bool EsUsuario{ get; set; }
            public int Edad { get; set; }

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        public partial class GestionEmpleados2023 {
            private SqlConnection conexionConSql;
            public GestionEmpleados2023() {
                EstablecerConexion();
            }
            private void EstablecerConexion() {
                string CadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString;
                conexionConSql = new SqlConnection(CadenaDeConexion);
            }
            public List<Empleado> ObtenerEmpleados()
            {
                EstablecerConexion();

                string consulta = "SELECT * FROM EMPLEADOS";
                DataTable Empleados = new DataTable();

                List<Empleado> listaEmpleados = new List<Empleado>();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionConSql);

                using (adaptador)
                {
                    adaptador.Fill(Empleados);
                }
                listaEmpleados = Empleados.AsEnumerable().Select(row => new Empleado
                { 
                    Nombre = row.Field<string>("Nombre"),
                    Apellido = row.Field<string>("Apellidos"),
                    EsUsuario = (row["EsUsuario"] != DBNull.Value) ? row.Field<bool>("EsUsuario") : false,
                    Edad = row.Field<int>("Edad")
                }).ToList();

                return listaEmpleados;
            }
        }
    }
}
