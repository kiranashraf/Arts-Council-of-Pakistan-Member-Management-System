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
    public partial class expiredmem : Form
    {
        public expiredmem()
        {
            InitializeComponent();
        }
        MySqlDataAdapter adapter;
        Form1 mainForm;
         public expiredmem(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

         void LoadReport2()
         {

             string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
             MySqlConnection conn = new MySqlConnection(conString);
             string query = String.Format("SELECT a.Name,a.Memno FROM {0} AS {1} ", "expiredmem01", "a");
             try
             {
                 conn.Open();
                 MySqlCommand command = new MySqlCommand(query, conn);
                 adapter = new MySqlDataAdapter(command);
                 DataSet data = new DataSet();
                 adapter.Fill(data, "all_members");
                 data.WriteXml(@"D:\dataset.xml", XmlWriteMode.WriteSchema);
                 CrystalReport5 cr = new CrystalReport5();
                 cr.SetDataSource(data);
                 ReportDocument ObjReport = new ReportDocument();

                 crystalReportViewer1.ReportSource = cr;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }

         private void crystalReportViewer1_Load(object sender, EventArgs e)
         {
             LoadReport2();
         }
    }
}
