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
/*PARA PODER EJECUTAR ESTE PROGRAMA, LO PRIMERO QUE SE DEBE DE HACER ES CREAR UNA BASE DE DATOS DESPUES SE DEBE DE INICIAR EL SERVIDOR DE LA BASE DE DATOS. QUE SE ENCUENTRA EN ThisPC/OS/XAMPP Y EJECUTABLE*/
namespace Practica7
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; username=root; password= ; database=topicospra7");
        public Form1()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE Nombre ='"+ textBox_user.Text+"' AND Password='"+textBox_Password.Text+"'",con);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                con.Close();
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            else { 
                MessageBox.Show( "Error!! los datos son incorrectos");
               
                con.Close();
            }
        }

        private void TextBox_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
