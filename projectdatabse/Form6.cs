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
    public partial class Form6 : Form
    {
        
        int id;
        OpenFileDialog ofd;
        Form2 memform;
        Form4 memform1;
        Form5 memform2;
        Form3 memform3;
        Form7 memform4; 

        int f,ind;
        public Form6()
        {
            InitializeComponent();
        }
        
        public Form6(int id)
        {
            //this.mainForm1 = mainForm1;
            //this.mainForm1.Enabled = false;
            this.id = id;
            InitializeComponent();
           
            
        }

        public Form6(int id,Form2 memform)
        {
            
            this.id = id;
            this.memform = memform;
            InitializeComponent();
            f = 0;

        }

        public Form6(int id, Form4 memform, int ind)
        {

            this.id = id;
            this.memform1 = memform;
            this.ind = ind;
            InitializeComponent();
            f = 1;
        }

        public Form6(int id, Form5 memform,int ind)
        {

            this.id = id;
            this.memform2 = memform;
            this.ind = ind;
            InitializeComponent();
            f = 2;

        }

       public Form6(int id, Form3 memform)
        {

            this.id = id;
            this.memform3 = memform;
            InitializeComponent();
            f = 3;

        }

       public Form6(int id, Form7 memform)
       {

           this.id = id;
           this.memform4 = memform;
           InitializeComponent();
           f = 4;

       }


        private void button1_Click(object sender, EventArgs e)
        {
           
            ofd = new OpenFileDialog();
            
            ofd.Filter = "image files|*.jpg;*.png;*.gif;*.jpeg";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;
            pictureBox1.Image = Image.FromFile(ofd.FileName);
            img.Text = ofd.FileName;

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectfile = id + ".jpg";
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = conn.CreateCommand();

            if (f == 0)
            {
                command.CommandText = @"UPDATE all_members SET image = @selectfile WHERE ID = @ID";


                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@selectfile", selectfile);
                try
                {
                    conn.Open();
                    command.ExecuteScalar();
                    conn.Close();
                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }
                Image originalImage = Image.FromFile(ofd.FileName);
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + selectfile;
                originalImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    memform.img.Text = "";

                MessageBox.Show("Your Picture has been added Succesfully", "Congratulations");
                this.Close();
                    memform.img.Text = selectfile;
            }

            else if (f == 1)
            {
                command.CommandText = @"UPDATE remove_members SET image = @selectfile WHERE ID = @ID";


                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@selectfile", selectfile);
                try
                {
                    conn.Open();
                    command.ExecuteScalar();
                    conn.Close();
                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }
                Image originalImage = Image.FromFile(ofd.FileName);
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + selectfile;
                originalImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
               
                    Image image = Image.FromFile(filePath);
                    memform1.dataGridView1.Rows[ind].Cells["img"].Value = image;
               
                MessageBox.Show("Your Picture has been added Succesfully", "Congratulations");
                this.Close();
               
            }

            else if (f == 2)
            {
                command.CommandText = @"UPDATE expiredmem SET image = @selectfile WHERE ID = @ID";


                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@selectfile", selectfile);
                try
                {
                    conn.Open();
                    command.ExecuteScalar();
                    conn.Close();
                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }
                Image originalImage = Image.FromFile(ofd.FileName);
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + selectfile;
                originalImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                Image image = Image.FromFile(filePath);
                memform2.dataGridView1.Rows[ind].Cells["img"].Value = image;

                MessageBox.Show("Your Picture has been added Succesfully", "Congratulations");
                this.Close();

            }


            if (f == 3)
            {
                
                command.CommandText = @"UPDATE all_staff SET image = @selectfile WHERE ID = @ID";


                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@selectfile", selectfile);
                try
                {
                    conn.Open();
                    command.ExecuteScalar();
                    conn.Close();
                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }
                Image originalImage = Image.FromFile(ofd.FileName);
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "staffpics/" + selectfile;
                originalImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                memform3.img.Text = "";

                MessageBox.Show("Your Picture has been added Succesfully", "Congratulations");
                this.Close();
                memform3.img.Text = selectfile;
            }

            if (f == 4)
            {
                command.CommandText = @"UPDATE honorary_members SET image = @selectfile WHERE ID = @ID";


                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@selectfile", selectfile);
                try
                {
                    conn.Open();
                    command.ExecuteScalar();
                    conn.Close();
                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }
                Image originalImage = Image.FromFile(ofd.FileName);
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "hmemberpics/" + selectfile;
                originalImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                //memform3.img.Text = "";

                MessageBox.Show("Your Picture has been added Succesfully", "Congratulations");
                this.Close();
                //memform3.img.Text = selectfile;
            }
        }


        
    }
}
