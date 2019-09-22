using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class CargarGrilla : Form
    {
        //defino la conexion a la base de datos u archivo
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=northwind");

        public CargarGrilla()
        {
            InitializeComponent();
        }

        private void cargarClientes()
        {
            //abro conexion
            con.Open();
            //ejecuto el SQL
            MySqlDataAdapter daClientes = new MySqlDataAdapter("SELECT * FROM Customers", con);
            //creo un DataSet para almacenar los datos
            DataSet dsClientes = new DataSet();
            //lleno el DataSet con la qry de SQL
            daClientes.Fill(dsClientes, "Customers");
            //asigno los datos al la grilla
            dgvClientes.DataSource = dsClientes;
            //se establece el nombre de la tabla cuyos datos se están mostrando en grilla 
            //se usa principalmente cuando se trabaja con un origen de datos que contiene varias tablas
            dgvClientes.DataMember = "Customers";
            //cierro la conexion
            con.Close();
        }

        private void CargarGrilla_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
    }
}
