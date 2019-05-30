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
    public partial class electionmember : Form
    {
        MySqlDataAdapter adapter;
        public electionmember()
        {
            InitializeComponent();
        }
         Form1 mainForm;
         public electionmember(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        void LoadReport2()
        {
 
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string query = String.Format("SELECT a.Mr_Mrs,a.Name,a.Memno,a.Add1,a.Add2,a.Add3,a.Add4,a.phone1,a.phone2,a.Mobile FROM {0} AS {1} INNER JOIN {2} AS {3} ON {4} = {5}", "all_members","a","memsub2012voter","b","a.Field1","b.Field1");
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data, "all_members");
                data.WriteXml(@"D:\dataset.xml", XmlWriteMode.WriteSchema);
                eligible2013 cr = new eligible2013();
                cr.SetDataSource(data);
                ReportDocument ObjReport = new ReportDocument();

                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            LoadReport2();
        }
    }
}
