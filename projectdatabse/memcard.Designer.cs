namespace projectdatabse
{
    partial class memcard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memcard));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.strmenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.lifeMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mNMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.memno = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orig = new System.Windows.Forms.ToolStripDropDownButton();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.secratery = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strmenu,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.memno,
            this.toolStripSeparator2,
            this.orig,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.secratery,
            this.toolStripSeparator4,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // strmenu
            // 
            this.strmenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lifeMembersToolStripMenuItem,
            this.patronMembersToolStripMenuItem,
            this.mNMembersToolStripMenuItem});
            this.strmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.strmenu.Image = ((System.Drawing.Image)(resources.GetObject("strmenu.Image")));
            this.strmenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strmenu.Name = "strmenu";
            this.strmenu.Size = new System.Drawing.Size(116, 22);
            this.strmenu.Text = "Membership Type";
            // 
            // lifeMembersToolStripMenuItem
            // 
            this.lifeMembersToolStripMenuItem.Name = "lifeMembersToolStripMenuItem";
            this.lifeMembersToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lifeMembersToolStripMenuItem.Text = "Life Members";
            this.lifeMembersToolStripMenuItem.Click += new System.EventHandler(this.lifeMembersToolStripMenuItem_Click);
            // 
            // patronMembersToolStripMenuItem
            // 
            this.patronMembersToolStripMenuItem.Name = "patronMembersToolStripMenuItem";
            this.patronMembersToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.patronMembersToolStripMenuItem.Text = "Patron Members";
            this.patronMembersToolStripMenuItem.Click += new System.EventHandler(this.patronMembersToolStripMenuItem_Click);
            // 
            // mNMembersToolStripMenuItem
            // 
            this.mNMembersToolStripMenuItem.Name = "mNMembersToolStripMenuItem";
            this.mNMembersToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mNMembersToolStripMenuItem.Text = "General Members";
            this.mNMembersToolStripMenuItem.Click += new System.EventHandler(this.mNMembersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 22);
            this.toolStripLabel1.Text = "Enter Membership No.";
            // 
            // memno
            // 
            this.memno.Name = "memno";
            this.memno.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 22);
            this.toolStripButton1.Text = "GO";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 25);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(959, 584);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // orig
            // 
            this.orig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.orig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem,
            this.duplicateToolStripMenuItem});
            this.orig.Image = ((System.Drawing.Image)(resources.GetObject("orig.Image")));
            this.orig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.orig.Name = "orig";
            this.orig.Size = new System.Drawing.Size(117, 22);
            this.orig.Text = "Orignial/Duplicate";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel2.Text = "Secratery";
            // 
            // secratery
            // 
            this.secratery.Name = "secratery";
            this.secratery.Size = new System.Drawing.Size(180, 25);
            this.secratery.Text = "PROF. EJAZ AHMED FARUQI";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // memcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 609);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "memcard";
            this.Text = "memcard";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton type;
        private System.Windows.Forms.ToolStripMenuItem lifeMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mNMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox memno;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ToolStripDropDownButton strmenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton orig;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox secratery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;


    }
}