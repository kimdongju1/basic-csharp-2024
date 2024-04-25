namespace ToyProject
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
            BtnTakeOut = new Button();
            BtnHere = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BtnTakeOut
            // 
            BtnTakeOut.Font = new Font("맑은 고딕", 20F);
            BtnTakeOut.Image = Properties.Resources.포장;
            BtnTakeOut.ImageAlign = ContentAlignment.MiddleRight;
            BtnTakeOut.Location = new Point(12, 74);
            BtnTakeOut.Name = "BtnTakeOut";
            BtnTakeOut.Size = new Size(269, 363);
            BtnTakeOut.TabIndex = 0;
            BtnTakeOut.Text = "테이크 아웃";
            BtnTakeOut.TextAlign = ContentAlignment.BottomCenter;
            BtnTakeOut.UseVisualStyleBackColor = true;
            BtnTakeOut.Click += BtnTakeOut_Click;
            // 
            // BtnHere
            // 
            BtnHere.Font = new Font("맑은 고딕", 20F);
            BtnHere.Image = (Image)resources.GetObject("BtnHere.Image");
            BtnHere.Location = new Point(299, 74);
            BtnHere.Name = "BtnHere";
            BtnHere.Size = new Size(271, 363);
            BtnHere.TabIndex = 1;
            BtnHere.Text = "매장에서 식사";
            BtnHere.TextAlign = ContentAlignment.BottomCenter;
            BtnHere.UseVisualStyleBackColor = true;
            BtnHere.Click += BtnHere_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
            textBox1.Location = new Point(87, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 36);
            textBox1.TabIndex = 4;
            textBox1.Text = "식사 방법을 선택해주세요";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 514);
            Controls.Add(textBox1);
            Controls.Add(BtnHere);
            Controls.Add(BtnTakeOut);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnTakeOut;
        private Button BtnHere;
        private TextBox textBox1;
    }
}
