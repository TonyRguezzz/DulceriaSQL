using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dulceria
{
    public partial class FrmProductoA : Form
    {
        //cadena de connexión
        MySqlConnection sqlConn = new MySqlConnection();

        //cadena de comandos
        MySqlCommand sqlCmd = new MySqlCommand();

        //para el manejo de tablas
        DataTable sqlDT = new DataTable();

        //el adaptador del odbc  Object Data Dase Conectivity
        MySqlDataAdapter DtA = new MySqlDataAdapter();

        //La lectura de la tabla
        MySqlDataReader sqlRd;

        //dataset connect with gridview
        DataSet Ds = new DataSet();

        string server = "localhost";
        string username = "root";
        string password = "Pokemonsoulsilver1909";
        string database = "dulceria";

        public FrmProductoA()
        {
            InitializeComponent();
        }

        private void FrmProductoA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO productos(IDPRO_PROD,IDPRO_NOM,IDPRO_PESO,IDPRO_MARCA,IDPRO_PRES,"
                + "IDPRO_COO,IDPRO_PPROV,IDPRO_PCTE,IDPRO_PUNIT,IDPRO_FCAD)" +
                " VALUES (" +
               textBoxProd.Text + "," +
               com.Text + textBoxDesc.Text + com.Text + "," +
               textBoxPeso.Text + "," +
               com.Text + textBoxMarca.Text + com.Text + "," +
               com.Text + textBoxDesc.Text + com.Text + "," +
               com.Text + textBoxCDB.Text + com.Text + "," +
               textBoxPreP.Text + ","+
               textBoxPrecioClien.Text + "," +
               textBoxPreUni.Text  + "," +
                com.Text + textBoxFDC.Text + com.Text 


               +");";
            textBox11.Text = consulta;

            //Codigo de conexion
            // insert
            sqlConn.ConnectionString = "server=" + server + ";" +
                                       "userid=" + username + ";" +
                                       "password=" + password + ";" +
                                       "database=" + database + ";";

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            
            sqlCmd.CommandText = textBox11.Text;

            sqlRd = sqlCmd.ExecuteReader();
            //sqlDT.Load(sqlRd);
            sqlRd.Close();


            sqlConn.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


