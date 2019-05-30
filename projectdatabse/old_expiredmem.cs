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

    public partial class old_expiredmem : Form
    {
        string filtertext = "Name";
        MySqlDataAdapter adapter;
        DataTable data;
        string mid;
        
        public old_expiredmem()
        {
            InitializeComponent();
        }

        Form1 mainForm;
        public old_expiredmem(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

        }

        private void old_expiredmem_Load(object sender, EventArgs e)
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string query = String.Format("SELECT * FROM {0}", "expiredmem01");

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

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
