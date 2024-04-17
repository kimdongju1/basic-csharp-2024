namespace ex18_winControlApp
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
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            ChkItalic = new CheckBox();
            chkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PrgDummy = new ProgressBar();
            TrbDummy = new TrackBar();
            groupBox3 = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox4 = new GroupBox();
            BtnAddChild = new Button();
            button1 = new Button();
            LsvDummy = new ListView();
            TrvDummy = new TreeView();
            Groupbox5 = new GroupBox();
            BtnLoad = new Button();
            PicNormal = new PictureBox();
            DlgOpenImage = new OpenFileDialog();
            GrbEditor = new GroupBox();
            BtnFileSave = new Button();
            BtnFileLoad = new Button();
            RtxEditor = new RichTextBox();
            groupBox6 = new GroupBox();
            BtnStop = new Button();
            BtnThread = new Button();
            BtnNothread = new Button();
            PrgProcess = new ProgressBar();
            TxtLog = new TextBox();
            BgwProgress = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            Groupbox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNormal).BeginInit();
            GrbEditor.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(chkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("나눔고딕", 8.999999F);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(28, 68);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(369, 21);
            TxtSampleText.TabIndex = 3;
            TxtSampleText.Text = "Hello, C#!";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕", 8.999999F, FontStyle.Italic);
            ChkItalic.Location = new Point(335, 34);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold);
            chkBold.ForeColor = Color.Black;
            chkBold.Location = new Point(283, 34);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(48, 18);
            chkBold.TabIndex = 2;
            chkBold.Text = "굵게";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.Font = new Font("나눔고딕", 8.999999F);
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(70, 32);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(200, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔고딕", 8.999999F);
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(36, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrgDummy);
            groupBox2.Controls.Add(TrbDummy);
            groupBox2.Location = new Point(16, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 프로그레스바";
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(9, 73);
            PrgDummy.Maximum = 20;
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(388, 23);
            PrgDummy.TabIndex = 1;
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(6, 25);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(397, 45);
            TrbDummy.TabIndex = 0;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuestion);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModal);
            groupBox3.Location = new Point(16, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 75);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창, 모달리스창";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Location = new Point(312, 22);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(85, 37);
            BtnQuestion.TabIndex = 1;
            BtnQuestion.Text = "...";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(189, 22);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(117, 37);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(100, 22);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(83, 37);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(12, 22);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(82, 37);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnAddChild);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(LsvDummy);
            groupBox4.Controls.Add(TrvDummy);
            groupBox4.Location = new Point(16, 331);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(409, 208);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰, 리스트뷰";
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(108, 161);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(89, 28);
            BtnAddChild.TabIndex = 3;
            BtnAddChild.Text = "자식추가";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 161);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 2;
            button1.Text = "루트추가";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnAddRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(203, 22);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(196, 130);
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(13, 22);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(184, 130);
            TrvDummy.TabIndex = 0;
            // 
            // Groupbox5
            // 
            Groupbox5.Controls.Add(BtnLoad);
            Groupbox5.Controls.Add(PicNormal);
            Groupbox5.Location = new Point(431, 12);
            Groupbox5.Name = "Groupbox5";
            Groupbox5.Size = new Size(356, 313);
            Groupbox5.TabIndex = 4;
            Groupbox5.TabStop = false;
            Groupbox5.Text = "픽쳐박스";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(275, 263);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // PicNormal
            // 
            PicNormal.BackColor = SystemColors.GrayText;
            PicNormal.Location = new Point(6, 22);
            PicNormal.Name = "PicNormal";
            PicNormal.Size = new Size(344, 235);
            PicNormal.TabIndex = 0;
            PicNormal.TabStop = false;
            PicNormal.Click += pictureBox1_Click;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // GrbEditor
            // 
            GrbEditor.Controls.Add(BtnFileSave);
            GrbEditor.Controls.Add(BtnFileLoad);
            GrbEditor.Controls.Add(RtxEditor);
            GrbEditor.Location = new Point(793, 12);
            GrbEditor.Name = "GrbEditor";
            GrbEditor.Size = new Size(383, 527);
            GrbEditor.TabIndex = 5;
            GrbEditor.TabStop = false;
            GrbEditor.Text = "텍스트에디터";
            // 
            // BtnFileSave
            // 
            BtnFileSave.Location = new Point(280, 477);
            BtnFileSave.Name = "BtnFileSave";
            BtnFileSave.Size = new Size(97, 30);
            BtnFileSave.TabIndex = 2;
            BtnFileSave.Text = "파일세이브";
            BtnFileSave.UseVisualStyleBackColor = true;
            BtnFileSave.Click += BtnFileSave_Click;
            // 
            // BtnFileLoad
            // 
            BtnFileLoad.Location = new Point(197, 477);
            BtnFileLoad.Name = "BtnFileLoad";
            BtnFileLoad.Size = new Size(80, 31);
            BtnFileLoad.TabIndex = 1;
            BtnFileLoad.Text = "파일로드";
            BtnFileLoad.UseVisualStyleBackColor = true;
            BtnFileLoad.Click += BtnFileLoad_Click;
            // 
            // RtxEditor
            // 
            RtxEditor.BorderStyle = BorderStyle.None;
            RtxEditor.Location = new Point(6, 22);
            RtxEditor.Name = "RtxEditor";
            RtxEditor.Size = new Size(371, 449);
            RtxEditor.TabIndex = 0;
            RtxEditor.Text = "";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnStop);
            groupBox6.Controls.Add(BtnThread);
            groupBox6.Controls.Add(BtnNothread);
            groupBox6.Controls.Add(PrgProcess);
            groupBox6.Controls.Add(TxtLog);
            groupBox6.Location = new Point(437, 331);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(350, 208);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "스레드, 백그라운드워커";
            // 
            // BtnStop
            // 
            BtnStop.Enabled = false;
            BtnStop.Location = new Point(262, 166);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(83, 36);
            BtnStop.TabIndex = 4;
            BtnStop.Text = "중지";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnThread
            // 
            BtnThread.Location = new Point(173, 166);
            BtnThread.Name = "BtnThread";
            BtnThread.Size = new Size(83, 36);
            BtnThread.TabIndex = 3;
            BtnThread.Text = "스레드";
            BtnThread.UseVisualStyleBackColor = true;
            BtnThread.Click += BtnThread_Click;
            // 
            // BtnNothread
            // 
            BtnNothread.Location = new Point(84, 166);
            BtnNothread.Name = "BtnNothread";
            BtnNothread.Size = new Size(83, 36);
            BtnNothread.TabIndex = 2;
            BtnNothread.Text = "노스레드";
            BtnNothread.UseVisualStyleBackColor = true;
            BtnNothread.Click += BtnNothread_Click;
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(6, 137);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(338, 23);
            PrgProcess.TabIndex = 1;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(6, 22);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(338, 109);
            TxtLog.TabIndex = 0;
            // 
            // BgwProgress
            // 
            BgwProgress.DoWork += BgwProgress_DoWork;
            BgwProgress.ProgressChanged += BgwProgress_ProgressChanged;
            BgwProgress.RunWorkerCompleted += BgwProgress_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 551);
            Controls.Add(groupBox6);
            Controls.Add(GrbEditor);
            Controls.Add(Groupbox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            Groupbox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNormal).EndInit();
            GrbEditor.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkBold;
        private ComboBox CboFonts;
        private Label label1;
        private TextBox TxtSampleText;
        private CheckBox ChkItalic;
        private GroupBox groupBox2;
        private ProgressBar PrgDummy;
        private TrackBar TrbDummy;
        private GroupBox groupBox3;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private Button BtnQuestion;
        private GroupBox groupBox4;
        private Button BtnAddChild;
        private Button button1;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private GroupBox Groupbox5;
        private Button BtnLoad;
        private PictureBox PicNormal;
        private OpenFileDialog DlgOpenImage;
        private GroupBox GrbEditor;
        private RichTextBox RtxEditor;
        private Button BtnFileSave;
        private Button BtnFileLoad;
        private GroupBox groupBox6;
        private Button BtnStop;
        private Button BtnThread;
        private Button BtnNothread;
        private ProgressBar PrgProcess;
        private TextBox TxtLog;
        private System.ComponentModel.BackgroundWorker BgwProgress;
    }
}
