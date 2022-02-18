namespace Clipart
{
    partial class Form1
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
            this.skapaGBX = new System.Windows.Forms.GroupBox();
            this.skapaLinBTN = new System.Windows.Forms.Button();
            this.skapaCirBTN = new System.Windows.Forms.Button();
            this.skapaTriBTN = new System.Windows.Forms.Button();
            this.höjdTBX = new System.Windows.Forms.TextBox();
            this.breddTBX = new System.Windows.Forms.TextBox();
            this.höjdLBL = new System.Windows.Forms.Label();
            this.breddLBL = new System.Windows.Forms.Label();
            this.sammanlagBTN = new System.Windows.Forms.Button();
            this.figurLBX = new System.Windows.Forms.ListBox();
            this.sammanlagTBX = new System.Windows.Forms.TextBox();
            this.figurLBL = new System.Windows.Forms.Label();
            this.sammanlagLBL = new System.Windows.Forms.Label();
            this.skapaGBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // skapaGBX
            // 
            this.skapaGBX.Controls.Add(this.skapaLinBTN);
            this.skapaGBX.Controls.Add(this.skapaCirBTN);
            this.skapaGBX.Controls.Add(this.skapaTriBTN);
            this.skapaGBX.Controls.Add(this.höjdTBX);
            this.skapaGBX.Controls.Add(this.breddTBX);
            this.skapaGBX.Controls.Add(this.höjdLBL);
            this.skapaGBX.Controls.Add(this.breddLBL);
            this.skapaGBX.Location = new System.Drawing.Point(9, 12);
            this.skapaGBX.Name = "skapaGBX";
            this.skapaGBX.Size = new System.Drawing.Size(261, 216);
            this.skapaGBX.TabIndex = 0;
            this.skapaGBX.TabStop = false;
            this.skapaGBX.Text = "Skapa";
            // 
            // skapaLinBTN
            // 
            this.skapaLinBTN.Location = new System.Drawing.Point(67, 175);
            this.skapaLinBTN.Name = "skapaLinBTN";
            this.skapaLinBTN.Size = new System.Drawing.Size(136, 29);
            this.skapaLinBTN.TabIndex = 5;
            this.skapaLinBTN.Text = "Skapa Linje";
            this.skapaLinBTN.UseVisualStyleBackColor = true;
            this.skapaLinBTN.Click += new System.EventHandler(this.skapaLinBTN_Click);
            // 
            // skapaCirBTN
            // 
            this.skapaCirBTN.Location = new System.Drawing.Point(67, 140);
            this.skapaCirBTN.Name = "skapaCirBTN";
            this.skapaCirBTN.Size = new System.Drawing.Size(136, 29);
            this.skapaCirBTN.TabIndex = 5;
            this.skapaCirBTN.Text = "Skapa Cirkel";
            this.skapaCirBTN.UseVisualStyleBackColor = true;
            this.skapaCirBTN.Click += new System.EventHandler(this.skapaCirBTN_Click);
            // 
            // skapaTriBTN
            // 
            this.skapaTriBTN.Location = new System.Drawing.Point(67, 105);
            this.skapaTriBTN.Name = "skapaTriBTN";
            this.skapaTriBTN.Size = new System.Drawing.Size(136, 29);
            this.skapaTriBTN.TabIndex = 4;
            this.skapaTriBTN.Text = "Skapa Triangel";
            this.skapaTriBTN.UseVisualStyleBackColor = true;
            this.skapaTriBTN.Click += new System.EventHandler(this.skapaTriBTN_Click);
            // 
            // höjdTBX
            // 
            this.höjdTBX.Location = new System.Drawing.Point(67, 68);
            this.höjdTBX.Name = "höjdTBX";
            this.höjdTBX.Size = new System.Drawing.Size(136, 22);
            this.höjdTBX.TabIndex = 3;
            // 
            // breddTBX
            // 
            this.breddTBX.Location = new System.Drawing.Point(67, 35);
            this.breddTBX.Name = "breddTBX";
            this.breddTBX.Size = new System.Drawing.Size(136, 22);
            this.breddTBX.TabIndex = 2;
            // 
            // höjdLBL
            // 
            this.höjdLBL.Location = new System.Drawing.Point(6, 67);
            this.höjdLBL.Name = "höjdLBL";
            this.höjdLBL.Size = new System.Drawing.Size(100, 23);
            this.höjdLBL.TabIndex = 1;
            this.höjdLBL.Text = "Höjd";
            // 
            // breddLBL
            // 
            this.breddLBL.Location = new System.Drawing.Point(6, 37);
            this.breddLBL.Name = "breddLBL";
            this.breddLBL.Size = new System.Drawing.Size(100, 23);
            this.breddLBL.TabIndex = 0;
            this.breddLBL.Text = "Bredd";
            // 
            // sammanlagBTN
            // 
            this.sammanlagBTN.Location = new System.Drawing.Point(76, 247);
            this.sammanlagBTN.Name = "sammanlagBTN";
            this.sammanlagBTN.Size = new System.Drawing.Size(136, 29);
            this.sammanlagBTN.TabIndex = 5;
            this.sammanlagBTN.Text = "Sammanlagd area";
            this.sammanlagBTN.UseVisualStyleBackColor = true;
            this.sammanlagBTN.Click += new System.EventHandler(this.sammanlagBTN_Click);
            // 
            // figurLBX
            // 
            this.figurLBX.FormattingEnabled = true;
            this.figurLBX.ItemHeight = 16;
            this.figurLBX.Location = new System.Drawing.Point(276, 47);
            this.figurLBX.Name = "figurLBX";
            this.figurLBX.Size = new System.Drawing.Size(162, 180);
            this.figurLBX.TabIndex = 6;
            // 
            // sammanlagTBX
            // 
            this.sammanlagTBX.Location = new System.Drawing.Point(276, 250);
            this.sammanlagTBX.Name = "sammanlagTBX";
            this.sammanlagTBX.Size = new System.Drawing.Size(162, 22);
            this.sammanlagTBX.TabIndex = 7;
            // 
            // figurLBL
            // 
            this.figurLBL.Location = new System.Drawing.Point(276, 21);
            this.figurLBL.Name = "figurLBL";
            this.figurLBL.Size = new System.Drawing.Size(100, 23);
            this.figurLBL.TabIndex = 8;
            this.figurLBL.Text = "Figurlista";
            // 
            // sammanlagLBL
            // 
            this.sammanlagLBL.Location = new System.Drawing.Point(276, 230);
            this.sammanlagLBL.Name = "sammanlagLBL";
            this.sammanlagLBL.Size = new System.Drawing.Size(162, 17);
            this.sammanlagLBL.TabIndex = 9;
            this.sammanlagLBL.Text = "Sammanlagd area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 294);
            this.Controls.Add(this.sammanlagLBL);
            this.Controls.Add(this.figurLBL);
            this.Controls.Add(this.sammanlagTBX);
            this.Controls.Add(this.figurLBX);
            this.Controls.Add(this.sammanlagBTN);
            this.Controls.Add(this.skapaGBX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.skapaGBX.ResumeLayout(false);
            this.skapaGBX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox sammanlagTBX;

        private System.Windows.Forms.GroupBox skapaGBX;
        private System.Windows.Forms.Label breddLBL;
        private System.Windows.Forms.Label höjdLBL;
        private System.Windows.Forms.TextBox breddTBX;
        private System.Windows.Forms.ListBox figurLBX;
        private System.Windows.Forms.TextBox höjdTBX;
        private System.Windows.Forms.Button skapaTriBTN;
        private System.Windows.Forms.Button skapaCirBTN;
        private System.Windows.Forms.Button skapaLinBTN;
        private System.Windows.Forms.Button sammanlagBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label figurLBL;
        private System.Windows.Forms.Label sammanlagLBL;

        #endregion
    }
}