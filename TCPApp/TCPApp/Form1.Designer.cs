﻿namespace TCPServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxSprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSprite
            // 
            this.pbxSprite.Image = ((System.Drawing.Image)(resources.GetObject("pbxSprite.Image")));
            this.pbxSprite.Location = new System.Drawing.Point(287, 67);
            this.pbxSprite.Name = "pbxSprite";
            this.pbxSprite.Size = new System.Drawing.Size(225, 300);
            this.pbxSprite.TabIndex = 0;
            this.pbxSprite.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxSprite);
            this.Name = "Form1";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbxSprite;
    }
}