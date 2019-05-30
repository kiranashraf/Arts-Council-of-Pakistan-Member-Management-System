using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectdatabse
{
    public partial class add_new : Form
    {
        public add_new()
        {
            InitializeComponent();
        }
        Form1 memform;

         public add_new(Form1 memform)
        {
            this.memform = memform;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "CREATE TABLE underpostal"+year.Text+" ( Id BIGINT(20) NOT NULL AUTO_INCREMENT PRIMARY KEY, Memno VARCHAR(10), Outstanding VARCHAR(20));";
           
            //command.Parameters.AddWithValue("@year", ");
            try
                {
                    conn.Open();
                    command.ExecuteScalar();
                    conn.Close();
                    MessageBox.Show("Your Table has been added Successfully! ", "Congratulations!");
                    this.Close();

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR !");


            }

            
            
        }

       
    }
}
