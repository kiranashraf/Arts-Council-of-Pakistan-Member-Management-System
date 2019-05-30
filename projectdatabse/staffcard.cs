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
using System.IO;

namespace projectdatabse
{
    public partial class staffcard : Form
    {
        public staffcard()
        {
            InitializeComponent();
        }
        MySqlDataAdapter adapter;
        string sec = "PROF. EJAZ AHMED FARUQI";
        Form1 mainForm;
        string dup = "";
       
        public staffcard(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadReport2();
        }

        private void LoadImage(DataRow objDataRow, string strImageField, string FilePath)
        {
            try
            {
                FileStream fs = new FileStream(FilePath,
                           System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] Image = new byte[fs.Length];
                fs.Read(Image, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                objDataRow[strImageField] = Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadReport2()
        {
            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string path = AppDomain.CurrentDomain.BaseDirectory + "staffpics\\";


            string query = String.Format("SELECT `Staffno`, `Mr_Mrs`,`Mobile`,`Profession`,`Name`,`Add1`,`Add2`,`Add3`,`Add4`,SUBSTRING(`nic`,1, 1)  AS '1',SUBSTRING(`nic`,2, 1)  AS '2',SUBSTRING(`nic`,3, 1)  AS '3', SUBSTRING(`nic`,4, 1)  AS '4',SUBSTRING(`nic`,5, 1)  AS '5',SUBSTRING(`nic`,6, 1)  AS '6',SUBSTRING(`nic`,7, 1)  AS '7',SUBSTRING(`nic`,8, 1)  AS '8',SUBSTRING(`nic`,9, 1)  AS '9',SUBSTRING(`nic`,10, 1)  AS '10',SUBSTRING(`nic`,11, 1)  AS '11',SUBSTRING(`nic`,12, 1)  AS '12',SUBSTRING(`nic`,13, 1)  AS '13',SUBSTRING(`nic`,14, 1)  AS '14',SUBSTRING(`nic`,15, 1)  AS '15',`image`, @orig AS 'ORIG', @secr AS 'SECRETARY'  FROM {0} WHERE `Staffno` = @memno", "all_staff");
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@memno", memno.Text);
                command.Parameters.AddWithValue("@orig", dup);
                command.Parameters.AddWithValue("@secr", secratery.Text);
                adapter = new MySqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data, "all_members");

                data.Tables[0].Columns.Add("Imagepath", typeof(string));

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    data.Tables[0].Rows[i]["Imagepath"] = path;
                }


                data.WriteXml(@"D:\dataset.xml", XmlWriteMode.WriteSchema);
                staff cr = new staff();
                cr.SetDataSource(data);
                ReportDocument ObjReport = new ReportDocument();

                crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orig.Text = originalToolStripMenuItem.Text;
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orig.Text = duplicateToolStripMenuItem.Text;
        }

       
    }
}
