namespace BookRentalShopApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            MnsBookRental = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3ToolStripMenuItem = new ToolStripMenuItem();
            StsBookRental = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            MnsBookRental.SuspendLayout();
            StsBookRental.SuspendLayout();
            SuspendLayout();
            // 
            // MnsBookRental
            // 
            MnsBookRental.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, toolStripMenuItem2ToolStripMenuItem, toolStripMenuItem3ToolStripMenuItem });
            MnsBookRental.Location = new Point(0, 0);
            MnsBookRental.Name = "MnsBookRental";
            MnsBookRental.Size = new Size(800, 24);
            MnsBookRental.TabIndex = 0;
            MnsBookRental.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(57, 20);
            파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // toolStripMenuItem2ToolStripMenuItem
            // 
            toolStripMenuItem2ToolStripMenuItem.Name = "toolStripMenuItem2ToolStripMenuItem";
            toolStripMenuItem2ToolStripMenuItem.Size = new Size(62, 20);
            toolStripMenuItem2ToolStripMenuItem.Text = "관리(&M)";
            // 
            // toolStripMenuItem3ToolStripMenuItem
            // 
            toolStripMenuItem3ToolStripMenuItem.Name = "toolStripMenuItem3ToolStripMenuItem";
            toolStripMenuItem3ToolStripMenuItem.Size = new Size(72, 20);
            toolStripMenuItem3ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // StsBookRental
            // 
            StsBookRental.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            StsBookRental.Location = new Point(0, 428);
            StsBookRental.Name = "StsBookRental";
            StsBookRental.Size = new Size(800, 22);
            StsBookRental.TabIndex = 1;
            StsBookRental.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(83, 17);
            toolStripStatusLabel1.Text = "로그인 아이디";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(40, 17);
            toolStripStatusLabel2.Text = "UserId";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(109, 17);
            toolStripStatusLabel3.Text = "LastLoginDateTime";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StsBookRental);
            Controls.Add(MnsBookRental);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MnsBookRental;
            Name = "FrmMain";
            Text = "책 대여점 v1.1";
            Load += FrmMain_Load;
            MnsBookRental.ResumeLayout(false);
            MnsBookRental.PerformLayout();
            StsBookRental.ResumeLayout(false);
            StsBookRental.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MnsBookRental;
        private StatusStrip StsBookRental;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3ToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}
