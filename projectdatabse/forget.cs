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
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }

        Form1 mainForm;
        int success = 0;
        string oldpass;
        string oldusername;
        public forget(Form1 mainForm)
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
                    if (username1.Text.Equals(myDataReader["Username"].ToString()))
                    {
                        if (password1.Text.Equals(myDataReader["Password"].ToString()))
                        {
                            oldpass = myDataReader["Password"].ToString();
                            oldusername = myDataReader["Username"].ToString();
                            success = 1;
                        }
                        else
                            MessageBox.Show("Invalid Old Username/Password");
                        

                    }
                    else
                        MessageBox.Show("Invalid Old Username/Password");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            if (success == 1)
            {
                MySqlCommand command1 = conn.CreateCommand();
                command1.CommandText = @"UPDATE login SET Username = @Username,Password = @Password WHERE Username=@user AND Password = @pass";
                command1.Parameters.AddWithValue("@user", username1.Text.ToString());
                command1.Parameters.AddWithValue("@Username", username2.Text.ToString());
                command1.Parameters.AddWithValue("@pass", password1.Text.ToString());
                command1.Parameters.AddWithValue("@Password", password2.Text.ToString());

                try
                {
                    conn.Open();
                    command1.ExecuteScalar();

                    command1.Parameters.Clear();
                    conn.Close();
                    MessageBox.Show("Your Password has been Changed Successfully", "Congratulations");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        
    }
}
