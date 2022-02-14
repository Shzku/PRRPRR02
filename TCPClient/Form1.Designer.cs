namespace TCPClient
{
    partial class Klient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIPInput = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // tbxIPInput
            // 
            this.tbxIPInput.Location = new System.Drawing.Point(173, 13);
            this.tbxIPInput.Name = "tbxIPInput";
            this.tbxIPInput.Size = new System.Drawing.Size(136, 31);
            this.tbxIPInput.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(315, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 34);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Anslut";
            this.btnConnect.UseMnemonic = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(160, 213);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(112, 34);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Upp";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(315, 301);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(112, 34);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Höger";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 301);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(112, 34);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Vänster";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(160, 404);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(112, 34);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Ner";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxIPInput);
            this.Controls.Add(this.label1);
            this.Name = "Klient";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbxIPInput;
        private Button btnConnect;
        private Button btnUp;
        private Button btnRight;
        private Button btnLeft;
        private Button btnDown;
    }
}