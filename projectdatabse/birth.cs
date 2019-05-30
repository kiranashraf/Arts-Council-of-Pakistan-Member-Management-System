﻿using System;
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
    public partial class Birth : Form
    {
    MySqlDataAdapter adapter;

        public Birth()
        {
            InitializeComponent();
        }
        Form1 mainForm;
        public Birth(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        void LoadReport2()
        {
            /*  MySqlConnection conn; 
  MySqlCommand cmd; 
  MySqlDataAdapter adap; 

  // Code to get data from database 
  conn = new MySqlConnection("Server=localhost; Database=saf; 
      User ID=root; Password=root; charset=utf8;"); conn.Open(); 
  cmd = conn.CreateCommand(); 
  cmd.CommandText = "SELECT customer_code, 
      customer_name, customer_address FROM Customers"; 
  // Create a Dataset and using DataAdapter to fill it 
  adap = new MySqlDataAdapter(); 
  adap.SelectCommand = cmd; 
  CustomerDS custDB = new CustomerDS(); 
  custDB.Clear(); 
  adap.Fill(custDB, "Customers"); */


            string conString = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
            MySqlConnection conn = new MySqlConnection(conString);
            string query = String.Format("SELECT `Mr_Mrs`,`Name`,DATE_FORMAT(`dob`,'%D %M') FROM {0}", "all_members");
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data, "all_members");
                data.WriteXml(@"D:\dataset.xml", XmlWriteMode.WriteSchema);
                Birthday cr = new Birthday();
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
