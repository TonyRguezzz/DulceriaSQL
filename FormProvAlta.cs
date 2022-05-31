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
    public partial class FormProvAlta : Form
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


        public FormProvAlta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO provedores(IDPROV_NOMBRE,IDPROV_PAIS,IDPROV_ESTADO,IDPROV_COMP,IDPROV_ID"
                + ",IDPROV_FENT)" +
                " VALUES (" +
               com.Text + textBoxProv.Text + com.Text + "," +
               com.Text + textBoxPais.Text + com.Text + "," +
               com.Text + textBoxEstado.Text + com.Text + "," +
               com.Text + textBoxCompañía.Text + com.Text + "," +
               textBoxIdentificador.Text + "," +
               com.Text + textBoxFDE.Text + com.Text


               + ");";


            textBox11.Text = consulta;


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
    }
}
