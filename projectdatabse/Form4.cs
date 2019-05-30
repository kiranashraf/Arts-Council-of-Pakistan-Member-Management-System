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
    public partial class Form4 : Form
    {
        string filtertext = "Name";
        MySqlDataAdapter adapter;
        DataTable data;
        string mid;
        int rec = 0;
        string dte=null;
        public Form4()
        {
            InitializeComponent();
        }

        Form1 mainForm;
        public Form4(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


                }

        private void button3_Click(object sender, EventArgs e)
        {
            //string Id="";
            

            if (this.mem_no.Text != "-")
            {
                myConnection abc = new myConnection();
                MySqlConnection conn = abc.GetConnection();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO  remove_members (Field1,Memno ,Mr_Mrs ,Name ,Father_Husband ,Receipt ,dob ,Add1 ,Add2 ,Add3 ,Add4 ,Town ,Area ,Phone1 ,Phone2 ,Mobile ,EMail ,Profession_MK ,Profession ,Qualification ,Proposed_by ,Seconder ,nic ,Category,foi1,foi2,foi3,image)"
                + "VALUES"
                + "(@Field,@Memno ,@Mr_Mrs ,@Name ,@Father_Husband ,@Receipt ,@dob ,@Add1 ,@Add2 ,@Add3 ,@Add4 ,@Town ,@Area ,@Phone1 ,@Phone2 ,@Mobile ,@EMail ,@Profession_MK ,@Profession ,@Qualification ,@Proposed_by ,@Seconder ,@nic ,@Category,@foi1,@foi2,@foi3,@image)";

                command.Parameters.AddWithValue("@FIELD", Field1.Text);
                command.Parameters.AddWithValue("@Memno", mem_no.Text);
                command.Parameters.AddWithValue("@Mr_Mrs", mr.Text);
                command.Parameters.AddWithValue("@Name", name.Text);
                command.Parameters.AddWithValue("@Father_Husband", father.Text);
                command.Parameters.AddWithValue("@Receipt", rec);

                //string db;

                command.Parameters.AddWithValue("@dob", Convert.ToDateTime(dte).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Add1", add1.Text);
                command.Parameters.AddWithValue("@Add2", add2.Text);
                command.Parameters.AddWithValue("@Add3", add3.Text);
                command.Parameters.AddWithValue("@Add4", add4.Text);
                command.Parameters.AddWithValue("@Town", town.Text);
                command.Parameters.AddWithValue("@Area", area.Text);
                command.Parameters.AddWithValue("@Phone1", phone1.Text);
                command.Parameters.AddWithValue("@Phone2", phone2.Text);
                command.Parameters.AddWithValue("@Mobile", mobile.Text);
                command.Parameters.AddWithValue("@EMail", email.Text);
                command.Parameters.AddWithValue("@Profession_MK", professionmk.Text);
                command.Parameters.AddWithValue("@Profession", profession.Text);
                command.Parameters.AddWithValue("@Qualification", qualification.Text);
                command.Parameters.AddWithValue("@Proposed_by", proposedby.Text);
                command.Parameters.AddWithValue("@Seconder", seconder.Text);
                command.Parameters.AddWithValue("@nic", nic.Text);
                command.Parameters.AddWithValue("@Category", category.Text);
                command.Parameters.AddWithValue("@foi1", foi1.Text);
                command.Parameters.AddWithValue("@foi2", foi2.Text);
                command.Parameters.AddWithValue("@foi3", foi3.Text);
                command.Parameters.AddWithValue("@image", mid);

                try
                {

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }
                 MySqlParameter myParam = new MySqlParameter();   
                 string my_Param = membership.Text;
                 myParam.ParameterName = "@my_Param";
                 myParam.Value = my_Param;

                command.CommandText = "DELETE FROM all_members WHERE Memno = '" + @my_Param + "'";
               
                //command.CommandType = CommandType.Text;
               
                 try
                    {

                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                     conn.Close();
                    
                    MessageBox.Show("Your Record has been Removed Successfully.", "Congratulations!");
                    tabControl1.SelectedTab = tabPage2;
                 }
                 catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }

                command.Parameters.Clear();
                }
            else
            MessageBox.Show("Please Choose Valid Member", "ERROR !");  
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            myConnection abc = new myConnection();
            MySqlConnection conn = abc.GetConnection();
            MySqlParameter myParam = new MySqlParameter();
            string my_Param = membership.Text;

            if (my_Param != null)
            {

                myParam.ParameterName = "@my_Param";
                myParam.Value = my_Param;
                string myQuery = "SELECT * FROM all_members WHERE Memno = '" + @my_Param + "'";
                //string conString = "Server=localhost;Port=3306;Database=acoapk;Uid=root;password=''";
                // MySqlConnection conn = new MySqlConnection(conString);
                try
                {
                MySqlCommand command = new MySqlCommand(myQuery, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(myParam);
                //command.Parameters.AddWithValue(@my_Param, my_Param);

                MySql.Data.MySqlClient.MySqlDataReader myDataReader;


                /* Open up the Connection to the Database */
                

                    myDataReader = command.ExecuteReader();
                    myDataReader.Read();



                    if (myDataReader.HasRows)
                    {
                        
                        myDataReader.Read();
                        //mid = Convert.ToInt32(myDataReader["ID"]);
                        if (!string.IsNullOrEmpty(myDataReader["Memno"].ToString()))
                            this.mem_no.Text = myDataReader.GetString("Memno").ToString();
                        if (!string.IsNullOrEmpty(myDataReader["Mr_Mrs"].ToString())) 
                            this.mr.Text = myDataReader.GetString("Mr_Mrs").ToString();
                        if (!string.IsNullOrEmpty(myDataReader["Name"].ToString())) 
                            this.name.Text = myDataReader.GetString("Name").ToString();
                        if (!string.IsNullOrEmpty(myDataReader["Father_Husband"].ToString())) 
                            this.father.Text = myDataReader.GetString("Father_Husband").ToString();
                        if ((Convert.IsDBNull(myDataReader["dob"].ToString())) || (myDataReader["dob"].ToString() != ""))
                        {
                            this.dob.Text = myDataReader.GetDateTime("dob").ToShortDateString();
                            //MessageBox.Show(myDataReader.GetDateTime("dob").ToShortDateString());
                           
                            dte = this.dob.Text;
                        }

                        if (!string.IsNullOrEmpty(myDataReader["Receipt"].ToString()))
                        {
                            this.receipt.Text = myDataReader.GetString("Receipt");
                            rec = Convert.ToInt32(receipt.Text);
                        }
                        
                        if (!string.IsNullOrEmpty(myDataReader["Add1"].ToString()))
                            this.add1.Text = myDataReader.GetString("Add1");
                        if (!string.IsNullOrEmpty(myDataReader["Add2"].ToString()))
                            this.add2.Text = myDataReader.GetString("Add2");
                        if (!string.IsNullOrEmpty(myDataReader["Add3"].ToString()))
                            this.add3.Text = myDataReader.GetString("Add3");
                        if (!string.IsNullOrEmpty(myDataReader["Add4"].ToString()))
                            this.add4.Text = myDataReader.GetString("Add4");
                        if (!string.IsNullOrEmpty(myDataReader["Town"].ToString()))
                            this.town.Text = myDataReader.GetString("Town");
                        if (!string.IsNullOrEmpty(myDataReader["Area"].ToString()))
                            this.area.Text = myDataReader.GetString("Area");
                        if (!string.IsNullOrEmpty(myDataReader["Phone1"].ToString()))
                            this.phone1.Text = myDataReader.GetString("Phone1");
                        if (!string.IsNullOrEmpty(myDataReader["Phone2"].ToString()))
                            this.phone2.Text = myDataReader.GetString("Phone2");
                        if (!string.IsNullOrEmpty(myDataReader["Mobile"].ToString()))
                            this.mobile.Text = myDataReader.GetString("Mobile");
                        if (!string.IsNullOrEmpty(myDataReader["Email"].ToString()))
                            this.email.Text = myDataReader.GetString("Email");
                        if (!string.IsNullOrEmpty(myDataReader["Profession_MK"].ToString()))
                            this.professionmk.Text = myDataReader.GetString("Profession_MK");
                        if (!string.IsNullOrEmpty(myDataReader["Profession"].ToString()))
                            this.profession.Text = myDataReader.GetString("Profession");
                        if (!string.IsNullOrEmpty(myDataReader["Qualification"].ToString()))
                            this.qualification.Text = myDataReader.GetString("Qualification");
                        if (!string.IsNullOrEmpty(myDataReader["Proposed_by"].ToString()))
                            this.proposedby.Text = myDataReader.GetString("Proposed_by");
                        if (!string.IsNullOrEmpty(myDataReader["Seconder"].ToString()))
                            this.seconder.Text = myDataReader.GetString("Seconder");
                        if (!string.IsNullOrEmpty(myDataReader["nic"].ToString()))
                            this.nic.Text = myDataReader.GetString("nic");
                        if (!string.IsNullOrEmpty(myDataReader["Category"].ToString()))
                            this.category.Text = myDataReader.GetString("Category");
                        if (!string.IsNullOrEmpty(myDataReader["foi1"].ToString()))
                            this.foi1.Text = myDataReader.GetString("foi1");
                        if (!string.IsNullOrEmpty(myDataReader["foi2"].ToString()))
                            this.foi2.Text = myDataReader.GetString("foi2");
                        if (!string.IsNullOrEmpty(myDataReader["foi3"].ToString()))
                            this.foi3.Text = myDataReader.GetString("foi3");
                        Field1.Text = myDataReader.GetString("Field1");
                        if (!string.IsNullOrEmpty(myDataReader["image"].ToString()))
                        {
                            pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + myDataReader["image"].ToString();
                            mid = myDataReader["image"].ToString();
                        }
                    }
                    else
                    {

                        this.mr.Text = "-";

                        this.name.Text = "-";

                        this.father.Text = "-";

                        this.receipt.Text = "0";

                        this.dob.Text = null;

                        this.add1.Text = "-";

                        this.add2.Text = "-";

                        this.add3.Text = "-";

                        this.add4.Text = "-";

                        this.town.Text = "-";
                        this.area.Text = "-";

                        this.phone1.Text = "-";

                        this.phone2.Text = "-";

                        this.mobile.Text = "-";

                        this.email.Text = "-";

                        this.professionmk.Text = "-";

                        this.profession.Text = "-";

                        this.qualification.Text = "-";

                        this.proposedby.Text = "-";

                        this.seconder.Text = "-";

                        this.nic.Text = "-";

                        this.category.Text = "-";
                        this.foi1.Text = "-";
                        this.foi2.Text = "-";
                        this.foi3.Text = "-";
                        MessageBox.Show("No Result found! ", "ERROR !");

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");

        }/* Execute the DataReader with our Search Query */
                    

            }


        }

       

        

        
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tabPage2.Width / 2.5);
            label25.Location = new Point(x, 30);
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string query = String.Format("SELECT `ID`,`Memno`, `Mr_Mrs`, `Name`, `Father_Husband`, `Receipt`, `Add1`, `Add2`, `Add3`, `Add4`, `Town`, `Area`, `Phone1`, `Phone2`, `Mobile`, `EMail`, `Profession_MK`, `dob` , `Profession`, `Qualification`, `Proposed_by`, `Seconder`, `nic`, `Category`,`foi1`,`foi2`,`foi3`,`image` FROM {0}", "remove_members");

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
                this.dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //int numColumnsForWidth = (dataGridView1.Width - 10) / (_imageSize + 20);
            try
            {
                
                for ( x = 0; x <= dataGridView1.Rows.Count - 2; x++)
                {

                    
                    if (dataGridView1.Rows[x].Cells["image"].Value.ToString() != "")
                    {
                        Image image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + dataGridView1.Rows[x].Cells["image"].Value.ToString());
                        dataGridView1.Rows[x].Cells["img"].Value = image;
                       
                    }
                    dataGridView1.Rows[x].Height = 50;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                MessageBox.Show("Update Failed"+ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["img"].Index && e.RowIndex >= 0)
            {
                
                int memid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                //MessageBox.Show(memid.ToString());
                Form6 subForm = new Form6(memid,this,e.RowIndex);
                subForm.Show();
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", filtertext, search.Text);
            //dataGridView1.DataSource = data;
            bindingSource1.DataSource = data;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            try
            {
                
                for (int x = 0; x <= dataGridView1.Rows.Count - 2; x++)
                {

                    
                    if (dataGridView1.Rows[x].Cells["image"].Value.ToString() != "")
                    {
                        Image image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + dataGridView1.Rows[x].Cells["image"].Value.ToString());
                        dataGridView1.Rows[x].Cells["img"].Value = image;
                       
                    }
                    dataGridView1.Rows[x].Height = 50;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void fatherHusbandNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = fatherHusbandNameToolStripMenuItem.Text;
            filtertext = "Father_Husband";
        }

        private void nICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = nICToolStripMenuItem.Text;
            filtertext = "nic";
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = emailToolStripMenuItem.Text;
            filtertext = "EMail";
        }

        private void mobileNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Text = mobileNoToolStripMenuItem.Text;
            filtertext = "Mobile";
        }

        private void Form4_Resize(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tabPage2.Width / 2.5);
            label25.Location = new Point(x, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

        

        
        

       

       
    }
}

