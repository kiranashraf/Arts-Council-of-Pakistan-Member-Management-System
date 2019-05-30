using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace projectdatabse
{
    public partial class Form3 : Form
    {
        MySqlDataAdapter adapter;
        DataTable data;
        string filtertext = "Name";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        Form1 mainForm;

        public Form3(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

        }


        
        public static bool isEmail(string inputEmail)
        {

            const string expression = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex regex = new Regex(expression);
            return regex.IsMatch(inputEmail);
        }

       

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Id = "";
            string staff = "";
            string mr = "";
            string name = "";
            string father = "";
            string dob = "";
            string nic = "";
            string add1 = "";
            string add2 = "";
            string add3 = "";
            string add4 = "";
            string town = "";
            string area = "";
            string phone1 = "";
            string phone2 = "";
            string mobile = "";
            string email = "";
            string professionmk = "";
            string profession = "";
            string qualification = "";
            string proposedby = "";
            string seconder = "";
            string category = "";
            string employee = "";
            int err = 0;

            if (this.staff.Text == string.Empty)
            {
                MessageBox.Show("Staff No. Field cannot be Empty");
                err = 1;
            }
            else if (this.name.Text == string.Empty)
            {
                MessageBox.Show("Name Field cannot be Empty");
                err = 1;
            }
            else if (this.mr.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select salautation ");
                err = 1;

            }


            if (this.name.Text != string.Empty)
            {
                name = this.name.Text.ToString();
            }

            if (this.staff.Text != string.Empty)
            {
                staff = this.staff.Text.ToString();
            }

            if (this.employee.Text != string.Empty)
            {
                employee = this.employee.Text.ToString();
            }

            if (this.father.Text != string.Empty)
            {
                father = this.father.Text.ToString();
            }
            

            if (this.nic.Text != string.Empty)
            {
                nic = this.nic.Text.ToString();

            }


            if (this.add1.Text != string.Empty)
            {
                add1 = this.add1.Text.ToString();
            }
            if (this.add2.Text != string.Empty)
            {
                add2 = this.add2.Text.ToString();
            }
            if (this.add3.Text != string.Empty)
            {
                add3 = this.add3.Text.ToString();
            }
            if (this.add4.Text != string.Empty)
            {
                add4 = this.add4.Text.ToString();
            }
            if (this.town.Text != string.Empty)
            {
                town = this.town.Text.ToString();
            }
            if (this.area.Text != string.Empty)
            {
                area = this.area.Text.ToString();
            }
            if (this.phone1.Text != string.Empty)
            {
                phone1 = this.phone1.Text.ToString();
            }
            if (this.phone2.Text != string.Empty)
            {
                phone2 = this.phone2.Text.ToString();
            }
            if (this.mobile.Text != string.Empty)
            {
                mobile = this.mobile.Text.ToString();
            }
            if (this.email.Text != string.Empty)
            {
                email = this.email.Text.ToString();
            }
            if (this.professionmk.Text != string.Empty)
            {
                professionmk = this.professionmk.Text.ToString();
            }
            if (this.profession.Text != string.Empty)
            {
                profession = this.profession.Text.ToString();
            }
            if (this.qualification.Text != string.Empty)
            {
                qualification = this.qualification.Text.ToString();
            }
            if (this.proposedby.Text != string.Empty)
            {
                proposedby = this.proposedby.Text.ToString();
            }
            if (this.seconder.Text != string.Empty)
            {
                seconder = this.seconder.Text.ToString();
            }
            if (this.category.Text != string.Empty)
            {
                category = this.category.Text.ToString();
            }
            mr = this.mr.Text;
            
          


            if (err != 1)
            {
                string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO  all_staff (Field1,Staffno ,Mr_Mrs ,Name ,Father_Husband ,dob ,Add1 ,Add2 ,Add3 ,Add4 ,Town ,Area ,Phone1 ,Phone2 ,Mobile ,EMail ,Profession_MK ,Profession ,Qualification ,Proposed_by ,Seconder ,nic ,Category,EmployeeID)"
                + "VALUES"
                + "(@Field1 ,@Staffno ,@Mr_Mrs ,@Name ,@Father_Husband ,@dob ,@Add1 ,@Add2 ,@Add3 ,@Add4 ,@Town ,@Area ,@Phone1 ,@Phone2 ,@Mobile ,@EMail ,@Profession_MK ,@Profession ,@Qualification ,@Proposed_by ,@Seconder ,@nic ,@Category,@EmployeeID);Select LAST_INSERT_ID();";


                command.Parameters.AddWithValue("@Field1", field.Text);
                command.Parameters.AddWithValue("@Staffno", staff);
                command.Parameters.AddWithValue("@Mr_Mrs", mr);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Father_Husband", father);
                command.Parameters.AddWithValue("@dob", Convert.ToDateTime(this.dob.Text).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Add1", add1);
                command.Parameters.AddWithValue("@Add2", add2);
                command.Parameters.AddWithValue("@Add3", add3);
                command.Parameters.AddWithValue("@Add4", add4);
                command.Parameters.AddWithValue("@Town", town);
                command.Parameters.AddWithValue("@Area", area);
                command.Parameters.AddWithValue("@Phone1", phone1);
                command.Parameters.AddWithValue("@Phone2", phone2);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@EMail", email);
                command.Parameters.AddWithValue("@Profession_MK", professionmk);
                command.Parameters.AddWithValue("@Profession", profession);
                command.Parameters.AddWithValue("@Qualification", qualification);
                command.Parameters.AddWithValue("@Proposed_by", proposedby);
                command.Parameters.AddWithValue("@Seconder", seconder);
                command.Parameters.AddWithValue("@nic", nic);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@EmployeeID", employee);
                try
                {
                    conn.Open();
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    conn.Close();
                    command.Parameters.Clear();
                    DialogResult dialogResult = MessageBox.Show("Your Record has been Added Successfully. Do you want to add Picture?", "Congratulations ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        Form6 subForm = new Form6(id, this);
                        subForm.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                    //test();
                    this.category.Text = "";
                    this.staff.Text = "";
                    this.mr.Text = "";
                    this.name.Text = "";
                    this.father.Text = "";
                    this.dob.Text = "";
                    this.nic.Text = "";
                    this.add1.Text = "";
                    this.add2.Text = "";
                    this.add3.Text = "";
                    this.add4.Text = "";
                    this.town.Text = "";
                    this.area.Text = "";
                    this.phone1.Text = "";
                    this.phone2.Text = "";
                    this.mobile.Text = "";
                    this.email.Text = "";
                    this.professionmk.Text = "";
                    this.profession.Text = "";
                    this.qualification.Text = "";
                    this.proposedby.Text = "";
                    this.seconder.Text = "";
                    this.field1.Text = "";
                    this.field2.Text = "";
                    this.field3.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");


                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void test()
        {
            subtest();
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string query = String.Format("SELECT `ID`,`Staffno`, `Mr_Mrs`, `Name`, `Father_Husband`,  `Add1`, `Add2`, `Add3`, `Add4`, `Town`, `Area`, `Phone1`, `Phone2`, `Mobile`, `EMail`, `Profession_MK`, `dob` , `Profession`, `Qualification`, `Proposed_by`, `Seconder`, `nic`, `Category`,`image`,`EmployeeID`,`foi1`,`foi2`,`foi3` FROM {0}", "all_staff");
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
            member.DataBindings.Add(new Binding("Text", bindingSource1, "Staffno", true, DataSourceUpdateMode.OnPropertyChanged));
            memname.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            mr_ms_mrs.DataBindings.Add(new Binding("Text", bindingSource1, "Mr_Mrs", true, DataSourceUpdateMode.OnPropertyChanged));
            fat_hub.DataBindings.Add(new Binding("Text", bindingSource1, "Father_Husband", true, DataSourceUpdateMode.OnPropertyChanged));
            date.DataBindings.Add(new Binding("Text", bindingSource1, "dob", true, DataSourceUpdateMode.OnPropertyChanged));
            nic_no.DataBindings.Add(new Binding("Text", bindingSource1, "nic", true, DataSourceUpdateMode.OnPropertyChanged));
            receipt_no.DataBindings.Add(new Binding("Text", bindingSource1, "EmployeeID", true, DataSourceUpdateMode.OnPropertyChanged));
             ph1.DataBindings.Add(new Binding("Text", bindingSource1, "Phone1", true, DataSourceUpdateMode.OnPropertyChanged));
            ph2.DataBindings.Add(new Binding("Text", bindingSource1, "Phone2", true, DataSourceUpdateMode.OnPropertyChanged));
            tonw.DataBindings.Add(new Binding("Text", bindingSource1, "Town", true, DataSourceUpdateMode.OnPropertyChanged));
            aream.DataBindings.Add(new Binding("Text", bindingSource1, "Area", true, DataSourceUpdateMode.OnPropertyChanged));
            mob.DataBindings.Add(new Binding("Text", bindingSource1, "Mobile", true, DataSourceUpdateMode.OnPropertyChanged));
            emailadd.DataBindings.Add(new Binding("Text", bindingSource1, "EMail", true, DataSourceUpdateMode.OnPropertyChanged));
            add_1.DataBindings.Add(new Binding("Text", bindingSource1, "Add1", true, DataSourceUpdateMode.OnPropertyChanged));
            add_2.DataBindings.Add(new Binding("Text", bindingSource1, "Add2", true, DataSourceUpdateMode.OnPropertyChanged));
            add_3.DataBindings.Add(new Binding("Text", bindingSource1, "Add3", true, DataSourceUpdateMode.OnPropertyChanged));
            add_4.DataBindings.Add(new Binding("Text", bindingSource1, "Add4", true, DataSourceUpdateMode.OnPropertyChanged));
            mkprofession.DataBindings.Add(new Binding("Text", bindingSource1, "Profession_MK", true, DataSourceUpdateMode.OnPropertyChanged));
            professionm.DataBindings.Add(new Binding("Text", bindingSource1, "Profession", true, DataSourceUpdateMode.OnPropertyChanged));
            qualificationm.DataBindings.Add(new Binding("Text", bindingSource1, "Qualification", true, DataSourceUpdateMode.OnPropertyChanged));
            proposed.DataBindings.Add(new Binding("Text", bindingSource1, "Proposed_by", true, DataSourceUpdateMode.OnPropertyChanged));
            sec.DataBindings.Add(new Binding("Text", bindingSource1, "Seconder", true, DataSourceUpdateMode.OnPropertyChanged));
            cat.DataBindings.Add(new Binding("Text", bindingSource1, "Category", true, DataSourceUpdateMode.OnPropertyChanged));
            memid.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true, DataSourceUpdateMode.OnPropertyChanged));
            img.DataBindings.Add(new Binding("Text", bindingSource1, "image", true, DataSourceUpdateMode.OnPropertyChanged));
            filed1.DataBindings.Add(new Binding("Text", bindingSource1, "foi1", true, DataSourceUpdateMode.OnPropertyChanged));
            fieldof2.DataBindings.Add(new Binding("Text", bindingSource1, "foi2", true, DataSourceUpdateMode.OnPropertyChanged));
            filed3.DataBindings.Add(new Binding("Text", bindingSource1, "foi3", true, DataSourceUpdateMode.OnPropertyChanged));

            if (img.Text != "")
                pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "staffpics/" + img.Text;

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
                MessageBox.Show("Update Failed" + ex.Message);
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

        private void go_Click(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", filtertext, search.Text);
            //dataGridView1.DataSource = data;
            bindingSource1.DataSource = data;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }

        public void subtest()
        {
            member.DataBindings.Clear();
            memname.DataBindings.Clear();
            mr_ms_mrs.DataBindings.Clear();
            fat_hub.DataBindings.Clear();
            date.DataBindings.Clear();
            nic_no.DataBindings.Clear();
            receipt_no.DataBindings.Clear();
            ph1.DataBindings.Clear();
            ph2.DataBindings.Clear();
            mob.DataBindings.Clear();
            emailadd.DataBindings.Clear();
            add_1.DataBindings.Clear();
            add_2.DataBindings.Clear();
            add_3.DataBindings.Clear();
            add_4.DataBindings.Clear();
            tonw.DataBindings.Clear();
            aream.DataBindings.Clear();
            mkprofession.DataBindings.Clear();
            professionm.DataBindings.Clear();
            qualificationm.DataBindings.Clear();
            proposed.DataBindings.Clear();
            sec.DataBindings.Clear();
            cat.DataBindings.Clear();
            memid.DataBindings.Clear();
            img.DataBindings.Clear();
            filed1.DataBindings.Clear();
            fieldof2.DataBindings.Clear();
            filed3.DataBindings.Clear();
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem3.Text;
            filtertext = "Father/Husband Name";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem4.Text;
            filtertext = "NIC";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem5.Text;
            filtertext = "Email";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem6.Text;
            filtertext = "Mobile";
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
            command.CommandText = @"UPDATE all_staff SET Staffno = @Memno,Mr_Mrs = @Mr_Mrs ,Name = @name ,Father_Husband =@Father_Husband,EmployeeID=@Receipt ,dob = @dob ,Add1 =@Add1,Add2 =@Add2,Add3 =@Add3,Add4 =@Add4 ,Town =@Town,Area =@Area,Phone1 =@Phone1,Phone2 =@Phone2,Mobile =@Mobile ,EMail =@Email,Profession_MK=@Profession_MK ,Profession=@Profession ,Qualification=@Qualification ,Proposed_by=@Proposed_by ,Seconder=@Seconder ,nic=@nic ,Category=@Category,foi1=@foi1,foi2=@foi2,foi3=@foi3 WHERE ID=@ID";


            command.Parameters.AddWithValue("@ID", memid.Text.ToString());
            command.Parameters.AddWithValue("@Memno", member.Text.ToString());
            command.Parameters.AddWithValue("@Mr_Mrs", mr_ms_mrs.Text.ToString());
            command.Parameters.AddWithValue("@Name", memname.Text.ToString());
            command.Parameters.AddWithValue("@Father_Husband", fat_hub.Text.ToString());
            command.Parameters.AddWithValue("@Receipt", receipt_no.Text.ToString());
            command.Parameters.AddWithValue("@dob", Convert.ToDateTime(this.date.Text).ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@Add1", add_1.Text.ToString());
            command.Parameters.AddWithValue("@Add2", add_2.Text.ToString());
            command.Parameters.AddWithValue("@Add3", add_3.Text.ToString());
            command.Parameters.AddWithValue("@Add4", add_4.Text.ToString());
            command.Parameters.AddWithValue("@Town", tonw.Text.ToString());
            command.Parameters.AddWithValue("@Area", aream.Text.ToString());
            command.Parameters.AddWithValue("@Phone1", ph1.Text.ToString());
            command.Parameters.AddWithValue("@Phone2", ph2.Text.ToString());
            command.Parameters.AddWithValue("@Mobile", mob.Text.ToString());
            command.Parameters.AddWithValue("@EMail", emailadd.Text.ToString());
            command.Parameters.AddWithValue("@Profession_MK", mkprofession.Text.ToString());
            command.Parameters.AddWithValue("@Profession", professionm.Text.ToString());
            command.Parameters.AddWithValue("@Qualification", qualificationm.Text.ToString());
            command.Parameters.AddWithValue("@Proposed_by", proposed.Text.ToString());
            command.Parameters.AddWithValue("@Seconder", sec.Text.ToString());
            command.Parameters.AddWithValue("@nic", nic_no.Text.ToString());
            command.Parameters.AddWithValue("@Category", cat.Text.ToString());
            command.Parameters.AddWithValue("@foi1", filed1.Text.ToString());
            command.Parameters.AddWithValue("@foi2", fieldof2.Text.ToString());
            command.Parameters.AddWithValue("@foi3", filed3.Text.ToString());
            
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
                MessageBox.Show("Update failed " + ex.Message , "Oopss");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = @"DELETE from all_staff  WHERE ID=@ID";
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

        private void img_TextChanged(object sender, EventArgs e)
        {
            if (img.Text != "")
            {
                pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "staffpics/" + img.Text;
            }
            else
                pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "staffpics/no_icon.gif";
        }


        

    }
}

