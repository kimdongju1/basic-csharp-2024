namespace ToyProject
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            MnuBurger = new Button();
            MnuDrink = new Button();
            MnuSide = new Button();
            BtnMenu01 = new Button();
            BtnMenu02 = new Button();
            BtnMenu03 = new Button();
            BtnMenu04 = new Button();
            BtnMenu05 = new Button();
            BtnMenu06 = new Button();
            BtnPay = new Button();
            PriceList = new ListBox();
            SuspendLayout();
            // 
            // MnuBurger
            // 
            MnuBurger.Location = new Point(12, 12);
            MnuBurger.Name = "MnuBurger";
            MnuBurger.Size = new Size(180, 63);
            MnuBurger.TabIndex = 0;
            MnuBurger.Text = "버거류";
            MnuBurger.UseVisualStyleBackColor = true;
            MnuBurger.Click += MnuBurger_Click;
            // 
            // MnuDrink
            // 
            MnuDrink.Location = new Point(198, 12);
            MnuDrink.Name = "MnuDrink";
            MnuDrink.Size = new Size(180, 63);
            MnuDrink.TabIndex = 1;
            MnuDrink.Text = "음료류";
            MnuDrink.UseVisualStyleBackColor = true;
            MnuDrink.Click += MnuDrink_Click;
            // 
            // MnuSide
            // 
            MnuSide.Location = new Point(384, 12);
            MnuSide.Name = "MnuSide";
            MnuSide.Size = new Size(180, 63);
            MnuSide.TabIndex = 2;
            MnuSide.Text = "사이드";
            MnuSide.UseVisualStyleBackColor = true;
            MnuSide.Click += MnuSide_Click;
            // 
            // BtnMenu01
            // 
            BtnMenu01.Location = new Point(13, 99);
            BtnMenu01.Name = "BtnMenu01";
            BtnMenu01.Size = new Size(180, 169);
            BtnMenu01.TabIndex = 4;
            BtnMenu01.Tag = "";
            BtnMenu01.TextAlign = ContentAlignment.BottomCenter;
            BtnMenu01.UseVisualStyleBackColor = true;
            BtnMenu01.Click += BtnMenu01_Click;
            // 
            // BtnMenu02
            // 
            BtnMenu02.Location = new Point(198, 99);
            BtnMenu02.Name = "BtnMenu02";
            BtnMenu02.Size = new Size(180, 169);
            BtnMenu02.TabIndex = 5;
            BtnMenu02.Tag = "";
            BtnMenu02.TextAlign = ContentAlignment.BottomCenter;
            BtnMenu02.UseVisualStyleBackColor = true;
            BtnMenu02.Click += BtnMenu02_Click;
            // 
            // BtnMenu03
            // 
            BtnMenu03.Location = new Point(383, 99);
            BtnMenu03.Name = "BtnMenu03";
            BtnMenu03.Size = new Size(180, 169);
            BtnMenu03.TabIndex = 6;
            BtnMenu03.Tag = "";
            BtnMenu03.TextAlign = ContentAlignment.BottomCenter;
            BtnMenu03.UseVisualStyleBackColor = true;
            BtnMenu03.Click += BtnMenu03_Click;
            // 
            // BtnMenu04
            // 
            BtnMenu04.Location = new Point(12, 274);
            BtnMenu04.Name = "BtnMenu04";
            BtnMenu04.Size = new Size(180, 169);
            BtnMenu04.TabIndex = 7;
            BtnMenu04.Tag = "";
            BtnMenu04.TextAlign = ContentAlignment.BottomCenter;
            BtnMenu04.UseVisualStyleBackColor = true;
            BtnMenu04.Click += BtnMenu04_Click;
            // 
            // BtnMenu05
            // 
            BtnMenu05.Location = new Point(198, 274);
            BtnMenu05.Name = "BtnMenu05";
            BtnMenu05.Size = new Size(180, 169);
            BtnMenu05.TabIndex = 8;
            BtnMenu05.Tag = "";
            BtnMenu05.TextAlign = ContentAlignment.BottomCenter;
            BtnMenu05.UseVisualStyleBackColor = true;
            BtnMenu05.Click += BtnMenu05_Click;
            // 
            // BtnMenu06
            // 
            BtnMenu06.Location = new Point(384, 274);
            BtnMenu06.Name = "BtnMenu06";
            BtnMenu06.Size = new Size(180, 169);
            BtnMenu06.TabIndex = 9;
            BtnMenu06.Tag = "";
            BtnMenu06.TextAlign = ContentAlignment.BottomCenter;
            BtnMenu06.UseVisualStyleBackColor = true;
            BtnMenu06.Click += BtnMenu06_Click;
            // 
            // BtnPay
            // 
            BtnPay.Location = new Point(12, 564);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(551, 67);
            BtnPay.TabIndex = 10;
            BtnPay.Text = "결제하기";
            BtnPay.UseVisualStyleBackColor = true;
            BtnPay.Click += BtnPay_Click;
            // 
            // PriceList
            // 
            PriceList.FormattingEnabled = true;
            PriceList.ItemHeight = 15;
            PriceList.Location = new Point(13, 451);
            PriceList.Name = "PriceList";
            PriceList.Size = new Size(550, 109);
            PriceList.TabIndex = 14;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 643);
            Controls.Add(PriceList);
            Controls.Add(BtnPay);
            Controls.Add(BtnMenu06);
            Controls.Add(BtnMenu05);
            Controls.Add(BtnMenu04);
            Controls.Add(BtnMenu03);
            Controls.Add(BtnMenu02);
            Controls.Add(BtnMenu01);
            Controls.Add(MnuSide);
            Controls.Add(MnuDrink);
            Controls.Add(MnuBurger);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button MnuBurger;
        private Button MnuDrink;
        private Button MnuSide;
        private Button BtnMenu01;
        private Button BtnMenu02;
        private Button BtnMenu03;
        private Button BtnMenu04;
        private Button BtnMenu05;
        private Button BtnMenu06;
        private Button BtnPay;
        private ListBox PriceList;
    }
}