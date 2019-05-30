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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        Form1 mainForm;
        int err;
        MySqlDataAdapter adapter;
        DataTable data;
        string filtertext = "Name";
        public Form7(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            //test();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.memno.Text == string.Empty)
                {
                    MessageBox.Show("Membership No. Field cannot be Empty");
                    err = 1;
                }
                else if (this.name.Text == string.Empty)
                {
                    MessageBox.Show("Name Field cannot be Empty");
                    err = 1;
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (err == 0)
            {
                string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO  honorary_members (Memno  ,Name ,Add1 ,Add2 ,Add3 ,Add4 ,Phone1 ,Phone2  ,EMail,Profession,foi1)"
                + "VALUES"
                + "(@Memno  ,@Name ,@Add1 ,@Add2 ,@Add3 ,@Add4 ,@Phone1 ,@Phone2 ,@EMail  ,@Profession,@foi1);Select LAST_INSERT_ID();";

                command.Parameters.AddWithValue("@Memno", memno.Text);
                //command.Parameters.AddWithValue("@Field1",  field.Text);
               
                command.Parameters.AddWithValue("@Name", name.Text);
                command.Parameters.AddWithValue("@Add1", add1.Text);
                command.Parameters.AddWithValue("@Add2", add2.Text);
                command.Parameters.AddWithValue("@Add3", add3.Text);
                command.Parameters.AddWithValue("@Add4", add4.Text);
                command.Parameters.AddWithValue("@Phone1", phone1.Text);
                command.Parameters.AddWithValue("@Phone2", phone2.Text);
                command.Parameters.AddWithValue("@EMail", email.Text);
                command.Parameters.AddWithValue("@Profession", profession.Text);
                command.Parameters.AddWithValue("@foi1", foi1.Text);
                 try
                {
                    conn.Open();
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    conn.Close();
                    command.Parameters.Clear();
                    DialogResult dialogResult = MessageBox.Show("Your Record has been Added Successfully. Do you want to add Picture?", "Congratulations ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                       
                        Form6 subForm = new Form6(id,this);
                        subForm.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                       
                    }
                    //test();
                  
                    this.memno.Text = "";
                   
                    this.name.Text = "";
                  
                    this.add1.Text = "";
                    this.add2.Text = "";
                    this.add3.Text = "";
                    this.add4.Text = "";
                
                    this.phone1.Text = "";
                    this.phone2.Text = "";
                 
                    this.email.Text = "";
                  
                    this.profession.Text = "";
                    
                    this.field1.Text = "";
                    tabControl1.SelectedTab = tabPage2;
                   

                }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "ERROR !");


                 }
                 command.Parameters.Clear();
                
               
            }


        }
        public void test()
        {
            subtest();
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string query = String.Format("SELECT `ID`,`Memno`,  `Name`,  `Add1`, `Add2`, `Add3`, `Add4`, `Phone1`, `Phone2`, `EMail`,`foi1`,`image`,`Profession` FROM {0}", "honorary_members");
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(command);
                data = new DataTable();
                adapter.Fill(data);
                bindingSource1 = new BindingSource();
                bindingSource1.DataSource = data;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                bindingNavigator2.BindingSource = bindingSource1;
                this.dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //member.Text=bindingSource1.Rows[0]["Memno"].ToString();
            member.DataBindings.Add(new Binding("Text", bindingSource1, "Memno", true, DataSourceUpdateMode.OnPropertyChanged));
            memname.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
              filed1.DataBindings.Add(new Binding("Text", bindingSource1, "foi1", true, DataSourceUpdateMode.OnPropertyChanged));
           ph1.DataBindings.Add(new Binding("Text", bindingSource1, "Phone1", true, DataSourceUpdateMode.OnPropertyChanged));
            ph2.DataBindings.Add(new Binding("Text", bindingSource1, "Phone2", true, DataSourceUpdateMode.OnPropertyChanged));
              emailadd.DataBindings.Add(new Binding("Text", bindingSource1, "EMail", true, DataSourceUpdateMode.OnPropertyChanged));
            add_1.DataBindings.Add(new Binding("Text", bindingSource1, "Add1", true, DataSourceUpdateMode.OnPropertyChanged));
            add_2.DataBindings.Add(new Binding("Text", bindingSource1, "Add2", true, DataSourceUpdateMode.OnPropertyChanged));
            add_3.DataBindings.Add(new Binding("Text", bindingSource1, "Add3", true, DataSourceUpdateMode.OnPropertyChanged));
            add_4.DataBindings.Add(new Binding("Text", bindingSource1, "Add4", true, DataSourceUpdateMode.OnPropertyChanged));
             professionm.DataBindings.Add(new Binding("Text", bindingSource1, "Profession", true, DataSourceUpdateMode.OnPropertyChanged));
              memid.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true, DataSourceUpdateMode.OnPropertyChanged));
            img.DataBindings.Add(new Binding("Text", bindingSource1, "image", true, DataSourceUpdateMode.OnPropertyChanged));
            if (img.Text != "")
                pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + img.Text;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            test();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
                cb.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
                adapter.UpdateCommand = cb.GetUpdateCommand();
                adapter.Update(data);
                bindingSource1.DataSource = data;


                MessageBox.Show("Update successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void membershipNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = membershipNoToolStripMenuItem.Text;
            filtertext = "Memno";
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = nameToolStripMenuItem.Text;
            filtertext = "Name";
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = emailToolStripMenuItem.Text;
            filtertext = "EMail";
        }

        private void mobileNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = mobileNoToolStripMenuItem.Text;
            filtertext = "Profession";
        }

        private void go_Click(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", filtertext, search.Text);
            //dataGridView1.DataSource = data;
            bindingSource1.DataSource = data;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void img_TextChanged(object sender, EventArgs e)
        {
            if (img.Text != "")
            {
                pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "hmemberpics/" + img.Text;
            }
            else
                pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "hmemberpics/no_icon.gif";
        }

        public void subtest()
        {
            member.DataBindings.Clear();
            memname.DataBindings.Clear();
            
            
           
            filed1.DataBindings.Clear();
           
            ph1.DataBindings.Clear();
            ph2.DataBindings.Clear();
           
            emailadd.DataBindings.Clear();
            add_1.DataBindings.Clear();
            add_2.DataBindings.Clear();
            add_3.DataBindings.Clear();
            add_4.DataBindings.Clear();
            
            professionm.DataBindings.Clear();
           
            memid.DataBindings.Clear();
            img.DataBindings.Clear();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem1.Text;
            filtertext = "Memno";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem2.Text;
            filtertext = "Name";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem5.Text;
            filtertext = "Email";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem6.Text;
            filtertext = "Profession";
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", filtertext, search1.Text);
            //dataGridView1.DataSource = data;
            bindingSource1.DataSource = data;
            //dataGridView1.DataSource = bindingSource1;
            bindingNavigator2.BindingSource = bindingSource1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 subForm = new Form6(Convert.ToInt32(memid.Text), this);
            subForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = @"UPDATE honorary_members SET Memno = @Memno ,Name = @name ,Add1 =@Add1,Add2 =@Add2,Add3 =@Add3,Add4 =@Add4 ,Phone1 =@Phone1,Phone2 =@Phone2,EMail =@Email,Profession=@Profession ,foi1=@foi1 WHERE ID=@ID";


            command.Parameters.AddWithValue("@ID", memid.Text.ToString());
            command.Parameters.AddWithValue("@Memno", member.Text.ToString());
           
            command.Parameters.AddWithValue("@Name", memname.Text.ToString());
           
          
            command.Parameters.AddWithValue("@Add1", add_1.Text.ToString());
            command.Parameters.AddWithValue("@Add2", add_2.Text.ToString());
            command.Parameters.AddWithValue("@Add3", add_3.Text.ToString());
            command.Parameters.AddWithValue("@Add4", add_4.Text.ToString());
     
            command.Parameters.AddWithValue("@Phone1", ph1.Text.ToString());
            command.Parameters.AddWithValue("@Phone2", ph2.Text.ToString());
           
            command.Parameters.AddWithValue("@EMail", emailadd.Text.ToString());
           
            command.Parameters.AddWithValue("@Profession", professionm.Text.ToString());
          
            command.Parameters.AddWithValue("@foi1", filed1.Text.ToString());
            
            try
            {
                conn.Open();
                command.ExecuteScalar();
                conn.Close();
                command.Parameters.Clear();
                MessageBox.Show("Your record has been Updated Successfully", "Congratulations");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed"+ex.Message, "Oopss");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = @"DELETE from honorary_members  WHERE ID=@ID";
            command.Parameters.AddWithValue("@ID", memid.Text.ToString());
            try
            {
                conn.Open();
                command.ExecuteScalar();
                conn.Close();
                command.Parameters.Clear();
                test();
                MessageBox.Show("Your record has been Deleted Successfully", "Congratulations");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed", "Oopss");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        


    }
}