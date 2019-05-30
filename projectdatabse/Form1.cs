using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectdatabse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Resize += Form1_Resize;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.Size = Screen.FromControl(this).Bounds.Size;
            this.Location=new Point(0,0);
           

            int x = Screen.FromControl(this).Bounds.Width;
            int y = Screen.FromControl(this).Bounds.Height;
           
            pictureBox1.Location = new Point(x / 3, y / 4);

            login log = new login(this);
            
           
            log.ShowDialog();
            
        }


       

        private void memberinsertion_Click(object sender, EventArgs e)
        {
            Form2 subForm = new Form2(this);
            subForm.Show();
        }

        private void removedmembers_Click(object sender, EventArgs e)
        {
            Form4 subForm2 = new Form4(this);
            subForm2.Show();
        }

        private void expiredmember_Click(object sender, EventArgs e)
        {
            Form5 subForm2 = new Form5(this);
            subForm2.Show();

        }

        private void staff_Click(object sender, EventArgs e)
        {

            
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form3 subForm1 = new Form3(this);
            subForm1.Show();
        }

        
        private void coOperativeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 subform = new Form8(this);
            subform.Show();
        }

        private void underPostal2005ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2005);
            subform.Show();
        }

        private void underPostal2006ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2006);
            subform.Show();
        }

        private void underPostal2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2007);
            subform.Show();
        }

        private void underPostal2008ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2008);
            subform.Show();
        }

        private void underPostal2009ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2009);
            subform.Show();
        }

        private void underPostal2010ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2010);
            subform.Show();
        }

        private void underPostal2011ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2011);
            subform.Show();
        }

        private void underPostalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2012);
            subform.Show();
        }

        private void underPostal2013ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2013);
            subform.Show();
        }

        private void underPostal2014ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 subform = new Form9(this, 2014);
            subform.Show();
        }

        private void memberVoterList2005ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2005);
            subform.Show();
        }

        private void memberVoterList2006ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2006);
            subform.Show();
        }

        private void memberVoterList2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2007);
            subform.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2009);
            subform.Show();
        }

        private void memberVoterList2010ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2010);
            subform.Show();
        }

        private void memberVoterList2011ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2011);
            subform.Show();
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2012);
            subform.Show();
        }

        private void memberVoterList2013ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2013);
            subform.Show();
        }

        private void memberVoterList2014ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subform = new Form10(this, 2014);
            subform.Show();
        }

        private void addressForBirthdayCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 rep = new report1(this);
            rep.Show();
        }

        private void birthdayCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Birth rep = new Birth(this);
            rep.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            electionmember rep = new electionmember(this);
            rep.Show();
        }

        private void expiredMemberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expired rep = new expired(this);
            rep.Show();
        }

        private void honoraryMembersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form7 subform3 = new Form7(this);
            subform3.Show();
        }

        private void expiredMembersOldTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            old_expiredmem sub = new old_expiredmem(this);
            sub.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = this.Width;
            int y = this.Height;
            
            pictureBox1.Location = new Point(x / 3, y / 4);
            int x1 = Convert.ToInt32(x / 1.75);
            label1.Location = new Point(x1, y / 12);
            this.Update();
            
        }

        private void oldExpiredMembersMembershipNosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expiredmem sub = new expiredmem(this);
            sub.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            honorary_mem sub = new honorary_mem(this);
            sub.Show();

        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            letter sub = new letter();
            sub.Show();
        }

        private void membershipCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memcard sub = new memcard();
            sub.Show();
        }

        private void staffCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staffcard sub = new staffcard();
            sub.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forget sub = new forget();
            sub.Show();
        }

        

       
        

       
    }
}
