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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Form1 mainForm;
        int year;
        string mid;
        int outs = 0;
        MySqlDataAdapter adapter;
        DataTable data;
        string filtertext = "Name";
        public Form9(Form1 mainForm, int year)
        {
            this.mainForm = mainForm;
            this.year = year;
            InitializeComponent();
            //test();
            head1.Text = "Under Postal Form " + year;
            head2.Text = "List of Under Postal Members " + year;
            label29.Text = "Under Postal Members " + year;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConnection abc = new myConnection();
            MySqlConnection conn = abc.GetConnection();
            MySqlParameter myParam = new MySqlParameter();
            string my_Param = membership.Text;


            outstanding.ReadOnly = false;

            if (my_Param != null)
            {

                myParam.ParameterName = "@my_Param";
                myParam.Value = my_Param;
                string myQuery = "SELECT * FROM all_members WHERE Memno = '" + @my_Param + "'";
                //string conString = "Server=localhost;Port=3306;Database=acoapk;Uid=root;password=''";
                // MySqlConnection conn = new MySqlConnection(conString);

                MySqlCommand command = new MySqlCommand(myQuery, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(myParam);
                //command.Parameters.AddWithValue(@my_Param, my_Param);

                MySql.Data.MySqlClient.MySqlDataReader myDataReader;
                try
                {

                    myDataReader = command.ExecuteReader();
                    myDataReader.Read();



                    if (myDataReader.HasRows)
                    {

                        myDataReader.Read();
                        //mid = Convert.ToInt32(myDataReader["ID"]);
                        if (!string.IsNullOrEmpty(myDataReader["Memno"].ToString()))
                            this.mem_no.Text = myDataReader.GetString("Memno").ToString();
                        if (!string.IsNullOrEmpty(myDataReader["Field1"].ToString()))
                            this.field1.Text = myDataReader.GetString("Field1").ToString();
                        if (!string.IsNullOrEmpty(myDataReader["Mr_Mrs"].ToString()))
                            this.mr.Text = myDataReader.GetString("Mr_Mrs").ToString();
                        if (!string.IsNullOrEmpty(myDataReader["Name"].ToString()))
                            this.name.Text = myDataReader.GetString("Name").ToString();
                        if (!string.IsNullOrEmpty(myDataReader["Father_Husband"].ToString()))
                            this.father.Text = myDataReader["Father_Husband"].ToString();
                        if ((Convert.IsDBNull(myDataReader["dob"].ToString())) || (myDataReader["dob"].ToString() != ""))
                            this.dob.Text = myDataReader.GetString("dob").ToString();

                        if (!string.IsNullOrEmpty(myDataReader["Receipt"].ToString()))
                            this.receipt.Text = myDataReader.GetString("Receipt");

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

                        this.receipt.Text = "-";

                        this.dob.Text = "-";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.mem_no.Text != "-")
            {
                if(this.outstanding.Text != string.Empty)
                outs = Convert.ToInt32(outstanding.Text);
                myConnection abc = new myConnection();
                MySqlConnection conn = abc.GetConnection();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO " + "underpostal" + year + " (Memno , Outstanding,Field1)"
                + "VALUES"
                + "(@Memno ,@Outstanding,@Field1 )";

                command.Parameters.AddWithValue("@Memno", mem_no.Text);
                command.Parameters.AddWithValue("@Outstanding", outs);
                command.Parameters.AddWithValue("@Field1", field1.Text);


                try
                {
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    MessageBox.Show("Your Record has been added successfully");
                    tabControl1.SelectedTab = tabPage2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR !");
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            test();
        }

        public void test()
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            subtest();
            if (tabControl1.SelectedTab == tabPage2)
            {

                string query = String.Format("SELECT * FROM " + "underpostal" + year);

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
            }
            else if (tabControl1.SelectedTab == tabPage1)
            {

                string query = String.Format("SELECT cooperative_form.ID,cooperative_form.Memno, all_members.Mr_Mrs, all_members.Name,cooperative_form.Outstanding,all_members.Father_Husband, all_members.Receipt, all_members.Add1, all_members.Add2, all_members.Add3, all_members.Add4, all_members.Town, all_members.Area, all_members.Phone1, all_members.Phone2, all_members.Mobile, all_members.EMail, all_members.Profession_MK, all_members.dob , all_members.Profession, all_members.Qualification, all_members.Proposed_by, all_members.Seconder, all_members.nic, all_members.Category,all_members.foi1,all_members.foi2,all_members.foi3,all_members.image FROM " + "underpostal" + year + " AS {0} LEFT JOIN {1} ON {2} = {3}", "cooperative_form", "all_members", "cooperative_form.Memno", "all_members.Memno");
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                    adapter = new MySqlDataAdapter(command);
                    data = new DataTable();
                    adapter.Fill(data);
                    bindingSource2 = new BindingSource();
                    bindingSource2.DataSource = data;
                    bindingNavigator2.BindingSource = bindingSource2;

                    formno.DataBindings.Add(new Binding("Text", bindingSource2, "Outstanding", true));
                    mem.DataBindings.Add(new Binding("Text", bindingSource2, "Memno", true));
                    member.DataBindings.Add(new Binding("Text", bindingSource2, "Memno", true));
                    memname.DataBindings.Add(new Binding("Text", bindingSource2, "Name", true));
                    mr_ms_mrs.DataBindings.Add(new Binding("Text", bindingSource2, "Mr_Mrs", true));
                    fat_hub.DataBindings.Add(new Binding("Text", bindingSource2, "Father_Husband", true));
                    date.DataBindings.Add(new Binding("Text", bindingSource2, "dob", true));
                    nic_no.DataBindings.Add(new Binding("Text", bindingSource2, "nic", true));
                    receipt_no.DataBindings.Add(new Binding("Text", bindingSource2, "Receipt", true));
                    filed1.DataBindings.Add(new Binding("Text", bindingSource2, "foi1", true));
                    fieldof2.DataBindings.Add(new Binding("Text", bindingSource2, "foi2", true));
                    filed3.DataBindings.Add(new Binding("Text", bindingSource2, "foi3", true));
                    ph1.DataBindings.Add(new Binding("Text", bindingSource2, "Phone1", true));
                    ph2.DataBindings.Add(new Binding("Text", bindingSource2, "Phone2", true));
                    tonw.DataBindings.Add(new Binding("Text", bindingSource2, "Town", true));
                    aream.DataBindings.Add(new Binding("Text", bindingSource2, "Area", true));
                    mob.DataBindings.Add(new Binding("Text", bindingSource2, "Mobile", true));
                    emailadd.DataBindings.Add(new Binding("Text", bindingSource2, "EMail", true));
                    add_1.DataBindings.Add(new Binding("Text", bindingSource2, "Add1", true));
                    add_2.DataBindings.Add(new Binding("Text", bindingSource2, "Add2", true));
                    add_3.DataBindings.Add(new Binding("Text", bindingSource2, "Add3", true));
                    add_4.DataBindings.Add(new Binding("Text", bindingSource2, "Add4", true));
                    mk.DataBindings.Add(new Binding("Text", bindingSource2, "Profession_MK", true));
                    professionm.DataBindings.Add(new Binding("Text", bindingSource2, "Profession", true));
                    qualificationm.DataBindings.Add(new Binding("Text", bindingSource2, "Qualification", true));
                    proposed.DataBindings.Add(new Binding("Text", bindingSource2, "Proposed_by", true));
                    sec.DataBindings.Add(new Binding("Text", bindingSource2, "Seconder", true));
                    cat.DataBindings.Add(new Binding("Text", bindingSource2, "Category", true));
                    memid.DataBindings.Add(new Binding("Text", bindingSource2, "ID", true));
                    img.DataBindings.Add(new Binding("Text", bindingSource2, "image", true));
                    if (img.Text != "")
                        pic1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "memberpics/" + img.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        public void subtest()
        {
            mem.DataBindings.Clear();
            formno.DataBindings.Clear();
            member.DataBindings.Clear();
            memname.DataBindings.Clear();
            mr_ms_mrs.DataBindings.Clear();
            fat_hub.DataBindings.Clear();
            date.DataBindings.Clear();
            nic_no.DataBindings.Clear();
            receipt_no.DataBindings.Clear();
            filed1.DataBindings.Clear();
            fieldof2.DataBindings.Clear();
            filed3.DataBindings.Clear();
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
            mk.DataBindings.Clear();
            professionm.DataBindings.Clear();
            qualificationm.DataBindings.Clear();
            proposed.DataBindings.Clear();
            sec.DataBindings.Clear();
            cat.DataBindings.Clear();
            memid.DataBindings.Clear();
            img.DataBindings.Clear();
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

        private void go_Click(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", filtertext, search.Text);
            //dataGridView1.DataSource = data;
            bindingSource1.DataSource = data;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = string.Format("{0} like '%{1}%'", filtertext, search1.Text);
            //dataGridView1.DataSource = data;
            bindingSource2.DataSource = data;
            //dataGridView1.DataSource = bindingSource1;
            bindingNavigator2.BindingSource = bindingSource2;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filter.Text = toolStripMenuItem1.Text;
            filtertext = "Memno";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = @"UPDATE " + "underpostal" + year + " SET Memno = @Memno, Outstanding = @form WHERE ID=@ID";
            command.Parameters.AddWithValue("@ID", memid.Text.ToString());
            command.Parameters.AddWithValue("@Memno", mem.Text.ToString());
            command.Parameters.AddWithValue("@Form", formno.Text.ToString());

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
                MessageBox.Show("Update failed " + ex.Message, "Oopss");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = @"DELETE from " + "underpostal" + year + " WHERE ID=@ID";
            command.Parameters.AddWithValue("@ID", memid.Text.ToString());
            try
            {
                conn.Open();
                command.ExecuteScalar();
                conn.Close();
                command.Parameters.Clear();
                //tabControl1.SelectedTab = tabPage2;
                test();

                MessageBox.Show("Your record has been Deleted Successfully", "Congratulations");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed", "Oopss");
            }
        }
    }
}