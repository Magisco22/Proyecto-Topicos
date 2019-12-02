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

namespace Practica7
{
    public partial class Form3_Modificar : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; username=root; password= ; database=topicospra7");

        public Form3_Modificar()
        {
            InitializeComponent();
        }
        private void Form3_Modificar_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
           
                
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //dataGridView1.DataSource = table;
        }

        private void Btn_GuardarModificacion_Click(object sender, EventArgs e)
        {
            this.Hide();//Cierra la ventana

            con.Open();
            try
            {

            
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET Nombre='" + txtBox_nomModificar.Text + "',password='" + txtBox_passModificar.Text + "'WHERE ID=" + txtBox_idBuscar.Text, con);
                MySqlDataReader leer = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
              
            }
            con.Close();
            CargarUsuarios();
            txtBox_nomModificar.Text = "";
            txtBox_passModificar.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtBox_idBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}

