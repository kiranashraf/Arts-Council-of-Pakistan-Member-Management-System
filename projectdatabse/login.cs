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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        Form1 mainForm;
        public login(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection abc = new myConnection();
            MySqlConnection conn = abc.GetConnection();
            string myQuery = "SELECT `Username`,`Password` FROM login ";
            try
            {
                MySqlCommand command = new MySqlCommand(myQuery, conn);
                MySql.Data.MySqlClient.MySqlDataReader myDataReader;


                /* Open up the Connection to the Database */


                myDataReader = command.ExecuteReader();
                myDataReader.Read();



                if (myDataReader.HasRows)
                {

                    myDataReader.Read();
                    if (username.Text.Equals(myDataReader["Username"].ToString()))
                    {
                        if (password.Text.Equals(myDataReader["Password"].ToString()))
                        {
                            MessageBox.Show("Login Sucessful");

                            this.Hide();

                        }
                        else
                            MessageBox.Show("Invalid Username/Password");

                    }
                    else
                        MessageBox.Show("Invalid Username/Password");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }
    }
}
