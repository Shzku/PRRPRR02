namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kundTextBox = new System.Windows.Forms.TextBox();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.antalDTextBox = new System.Windows.Forms.TextBox();
            this.bokaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kundListBox = new System.Windows.Forms.ListBox();
            this.sokKundButton = new System.Windows.Forms.Button();
            this.sokNamnTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kund";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antal Dagar";
            // 
            // kundTextBox
            // 
            this.kundTextBox.Location = new System.Drawing.Point(119, 9);
            this.kundTextBox.Name = "kundTextBox";
            this.kundTextBox.Size = new System.Drawing.Size(105, 22);
            this.kundTextBox.TabIndex = 3;
            this.kundTextBox.TextChanged += new System.EventHandler(this.kundTextBox_TextChanged);
            // 
            // destTextBox
            // 
            this.destTextBox.Location = new System.Drawing.Point(119, 56);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(105, 22);
            this.destTextBox.TabIndex = 4;
            this.destTextBox.TextChanged += new System.EventHandler(this.destTextBox_TextChanged);
            // 
            // antalDTextBox
            // 
            this.antalDTextBox.Location = new System.Drawing.Point(119, 108);
            this.antalDTextBox.Name = "antalDTextBox";
            this.antalDTextBox.Size = new System.Drawing.Size(105, 22);
            this.antalDTextBox.TabIndex = 5;
            this.antalDTextBox.TextChanged += new System.EventHandler(this.antalDTextBox_TextChanged);
            // 
            // bokaButton
            // 
            this.bokaButton.Location = new System.Drawing.Point(230, 108);
            this.bokaButton.Name = "bokaButton";
            this.bokaButton.Size = new System.Drawing.Size(80, 22);
            this.bokaButton.TabIndex = 6;
            this.bokaButton.Text = "Boka";
            this.bokaButton.UseVisualStyleBackColor = true;
            this.bokaButton.Click += new System.EventHandler(this.bokaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kundListBox);
            this.groupBox1.Controls.Add(this.sokKundButton);
            this.groupBox1.Controls.Add(this.sokNamnTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök kund";
            // 
            // kundListBox
            // 
            this.kundListBox.FormattingEnabled = true;
            this.kundListBox.ItemHeight = 16;
            this.kundListBox.Location = new System.Drawing.Point(6, 75);
            this.kundListBox.Name = "kundListBox";
            this.kundListBox.Size = new System.Drawing.Size(289, 100);
            this.kundListBox.TabIndex = 3;
            this.kundListBox.SelectedIndexChanged += new System.EventHandler(this.kundListBox_SelectedIndexChanged);
            // 
            // sokKundButton
            // 
            this.sokKundButton.Location = new System.Drawing.Point(208, 27);
            this.sokKundButton.Name = "sokKundButton";
            this.sokKundButton.Size = new System.Drawing.Size(88, 31);
            this.sokKundButton.TabIndex = 2;
            this.sokKundButton.Text = "Sök";
            this.sokKundButton.UseVisualStyleBackColor = true;
            this.sokKundButton.Click += new System.EventHandler(this.sokKundButton_Click);
            // 
            // sokNamnTextBox
            // 
            this.sokNamnTextBox.Location = new System.Drawing.Point(71, 31);
            this.sokNamnTextBox.Name = "sokNamnTextBox";
            this.sokNamnTextBox.Size = new System.Drawing.Size(131, 22);
            this.sokNamnTextBox.TabIndex = 1;
            this.sokNamnTextBox.TextChanged += new System.EventHandler(this.sokNamnTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Namn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bokaButton);
            this.Controls.Add(this.antalDTextBox);
            this.Controls.Add(this.destTextBox);
            this.Controls.Add(this.kundTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button sokKundButton;

        private System.Windows.Forms.TextBox sokNamnTextBox;

        private System.Windows.Forms.Button bokaButton;

        private System.Windows.Forms.TextBox antalDTextBox;

        private System.Windows.Forms.TextBox destTextBox;

        private System.Windows.Forms.TextBox kundTextBox;

        private System.Windows.Forms.ListBox kundListBox;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}