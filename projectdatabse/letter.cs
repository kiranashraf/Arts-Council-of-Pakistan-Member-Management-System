using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;


namespace projectdatabse
{
    public partial class letter : Form
    {
        MySqlDataAdapter adapter;
        public letter()
        {
            InitializeComponent();
        }

        private void letter_Resize(object sender, EventArgs e)
        {
            button1.Location = new Point(date.Location.X + date.Width + 6, date.Location.Y);
        }

        Form1 mainForm;
        public letter(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        void LoadReport2()
        {

            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string query = String.Format("SELECT a.Mr_Mrs,a.Name,a.Memno,a.Add1,a.Add2,a.Add3,a.Add4,b.Outstanding , @date AS DATE FROM {0} AS {1} INNER JOIN {2} AS {3} ON {4} = {5}  ", "all_members", "a", "underpostal2013", "b", "a.Memno", "b.Memno");
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@date", date.Text);
                adapter = new MySqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data, "all_members");
                data.WriteXml(@"D:\dataset.xml", XmlWriteMode.WriteSchema);
                outstanding cr = new outstanding();
                cr.SetDataSource(data);
                ReportDocument ObjReport = new ReportDocument();

                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void letter_Load(object sender, EventArgs e)
        {
            //LoadReport2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadReport2();
        }
    }
}
