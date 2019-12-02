using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Practica7
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; username=root; password= ; database=topicospra7");
     
        public Form2()
        {
            InitializeComponent();
        }
       
        private void Form2_Load_1(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(txtBoxNombre.Text) || !string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            //{
                con.Open();
                try
                {


                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(Nombre,Password) VALUES(?Nombre,?Password)", con);
                    cmd.Parameters.Add("?Nombre", MySqlDbType.VarChar).Value = txtBoxNombre.Text;
                    cmd.Parameters.Add("?Password", MySqlDbType.VarChar).Value = txtBoxPassword.Text;
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error Al Agregar Renglon. Error: " + ex.Message);
                }
                con.Close();
                CargarUsuarios();
                txtBoxNombre.Text = "";
                txtBoxPassword.Text = "";
        }
            //else
            //{
            //    MessageBox.Show(" ******* ");
            //}
        //}

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Form3_Modificar f3 = new Form3_Modificar();
            f3.Show();
        }
    



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            {
                con.Open();
                try
                {

                    DialogResult r = MessageBox.Show("Desea borrar el registo", "BORRAR", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {

                        MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE ID=" + txtBoxEliminar.Text.Trim(), con);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        //dataGridView2.Rows.Remove(dataGridView2.CurrentRow); //Elimina Haciendo un seleccionador en la consulta
                    }

                    else
                    {
                        MessageBox.Show("No se elimino el registro" + MessageBoxIcon.Error);
                    }
                    txtBoxEliminar.Text = "";
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error Al Agregar Renglon. Error: " + ex.Message);
                }
                con.Close();
                //CargarUsuarios();
                txtBoxNombre.Text = "";
                txtBoxPassword.Text = "";
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE ID=" + txtBoxEliminar.Text, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY REGISTROS");
            }
            else
            {
                dataGridView2.DataSource = table;
                txtBoxEliminar.Text = "";
            }
            con.Close();
            
        }
    }
}