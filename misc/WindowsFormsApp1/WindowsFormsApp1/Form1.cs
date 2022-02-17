using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Höjdhoppare> hoppare = new List<Höjdhoppare>();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInmat = new System.Windows.Forms.Button();
            this.textBoxHopp = new System.Windows.Forms.TextBox();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.labelHopp = new System.Windows.Forms.Label();
            this.labelNamn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInmat);
            this.groupBox1.Controls.Add(this.textBoxHopp);
            this.groupBox1.Controls.Add(this.textBoxNamn);
            this.groupBox1.Controls.Add(this.labelHopp);
            this.groupBox1.Controls.Add(this.labelNamn);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inmatningar";
            // 
            // buttonInmat
            // 
            this.buttonInmat.Location = new System.Drawing.Point(138, 185);
            this.buttonInmat.Name = "buttonInmat";
            this.buttonInmat.Size = new System.Drawing.Size(105, 29);
            this.buttonInmat.TabIndex = 4;
            this.buttonInmat.Text = "Lägg Till";
            this.buttonInmat.UseVisualStyleBackColor = true;
            this.buttonInmat.Click += new System.EventHandler(this.buttonInmat_Click_1);
            // 
            // textBoxHopp
            // 
            this.textBoxHopp.Location = new System.Drawing.Point(140, 130);
            this.textBoxHopp.Name = "textBoxHopp";
            this.textBoxHopp.Size = new System.Drawing.Size(159, 22);
            this.textBoxHopp.TabIndex = 3;
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(148, 63);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(152, 22);
            this.textBoxNamn.TabIndex = 2;
            // 
            // labelHopp
            // 
            this.labelHopp.Location = new System.Drawing.Point(38, 127);
            this.labelHopp.Name = "labelHopp";
            this.labelHopp.Size = new System.Drawing.Size(59, 22);
            this.labelHopp.TabIndex = 1;
            this.labelHopp.Text = "Hopp";
            // 
            // labelNamn
            // 
            this.labelNamn.Location = new System.Drawing.Point(41, 59);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(87, 32);
            this.labelNamn.TabIndex = 0;
            this.labelNamn.Text = "Namn";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(441, 341);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label labelHopp;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxHopp;
        private System.Windows.Forms.Button buttonInmat;

        private void buttonInmat_Click_1(object sender, EventArgs e)
        {
            string namn = textBoxNamn.Text;
            double höjd = double.Parse(textBoxHopp.Text);

            hoppare.Add(new Höjdhoppare(namn, höjd));
            textBoxHopp.Clear();
            textBoxNamn.Clear();
        }
    }
}