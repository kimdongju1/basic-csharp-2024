namespace ToyProject
{
    partial class Form1
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
            BtnRed = new Button();
            BtnYello = new Button();
            BtnGreen = new Button();
            SuspendLayout();
            // 
            // BtnRed
            // 
            BtnRed.Location = new Point(31, 48);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(110, 101);
            BtnRed.TabIndex = 0;
            BtnRed.Text = "button1";
            BtnRed.UseVisualStyleBackColor = true;
            // 
            // BtnYello
            // 
            BtnYello.Location = new Point(166, 48);
            BtnYello.Name = "BtnYello";
            BtnYello.Size = new Size(110, 101);
            BtnYello.TabIndex = 1;
            BtnYello.Text = "button2";
            BtnYello.UseVisualStyleBackColor = true;
            // 
            // BtnGreen
            // 
            BtnGreen.Location = new Point(303, 48);
            BtnGreen.Name = "BtnGreen";
            BtnGreen.Size = new Size(110, 101);
            BtnGreen.TabIndex = 2;
            BtnGreen.Text = "button3";
            BtnGreen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGreen);
            Controls.Add(BtnYello);
            Controls.Add(BtnRed);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRed;
        private Button BtnYello;
        private Button BtnGreen;
    }
}
