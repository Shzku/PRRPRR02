namespace FotbollsLigan
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
      this.dgvMatcher = new System.Windows.Forms.DataGridView();
      this.HemmaLag = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BortaLag = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MålHemmaLag = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MålBortaLag = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnMålrikast = new System.Windows.Forms.Button();
      this.tbxMålrikast = new System.Windows.Forms.TextBox();
      this.btnStorstMål = new System.Windows.Forms.Button();
      this.btnFlyttRadNer = new System.Windows.Forms.Button();
      this.btnFlyttRadUpp = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvMatcher
      // 
      this.dgvMatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.HemmaLag, this.BortaLag, this.MålHemmaLag, this.MålBortaLag });
      this.dgvMatcher.Location = new System.Drawing.Point(7, 6);
      this.dgvMatcher.Name = "dgvMatcher";
      this.dgvMatcher.RowTemplate.Height = 24;
      this.dgvMatcher.Size = new System.Drawing.Size(640, 346);
      this.dgvMatcher.TabIndex = 0;
      this.dgvMatcher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatcher_CellEndEdit);
      this.dgvMatcher.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMatcher_UserAddedRow);
      this.dgvMatcher.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvMatcher_UserDeletingRow);
      // 
      // HemmaLag
      // 
      this.HemmaLag.HeaderText = "Hemmalag";
      this.HemmaLag.Name = "HemmaLag";
      // 
      // BortaLag
      // 
      this.BortaLag.HeaderText = "Bortalag";
      this.BortaLag.Name = "BortaLag";
      // 
      // MålHemmaLag
      // 
      this.MålHemmaLag.HeaderText = "Mål (H]";
      this.MålHemmaLag.Name = "MålHemmaLag";
      // 
      // MålBortaLag
      // 
      this.MålBortaLag.HeaderText = "Mål (B)";
      this.MålBortaLag.Name = "MålBortaLag";
      // 
      // btnMålrikast
      // 
      this.btnMålrikast.Location = new System.Drawing.Point(7, 359);
      this.btnMålrikast.Name = "btnMålrikast";
      this.btnMålrikast.Size = new System.Drawing.Size(114, 27);
      this.btnMålrikast.TabIndex = 1;
      this.btnMålrikast.Text = "Målrikast";
      this.btnMålrikast.UseVisualStyleBackColor = true;
      this.btnMålrikast.Click += new System.EventHandler(this.btnMålrikast_Click);
      // 
      // tbxMålrikast
      // 
      this.tbxMålrikast.Location = new System.Drawing.Point(246, 361);
      this.tbxMålrikast.Name = "tbxMålrikast";
      this.tbxMålrikast.Size = new System.Drawing.Size(398, 22);
      this.tbxMålrikast.TabIndex = 2;
      // 
      // btnStorstMål
      // 
      this.btnStorstMål.Location = new System.Drawing.Point(127, 360);
      this.btnStorstMål.Name = "btnStorstMål";
      this.btnStorstMål.Size = new System.Drawing.Size(113, 26);
      this.btnStorstMål.TabIndex = 3;
      this.btnStorstMål.Text = "Största Målskillnad";
      this.btnStorstMål.UseVisualStyleBackColor = true;
      this.btnStorstMål.Click += new System.EventHandler(this.btnStorstMål_Click);
      // 
      // btnFlyttRadNer
      // 
      this.btnFlyttRadNer.Location = new System.Drawing.Point(584, 384);
      this.btnFlyttRadNer.Name = "btnFlyttRadNer";
      this.btnFlyttRadNer.Size = new System.Drawing.Size(60, 34);
      this.btnFlyttRadNer.TabIndex = 4;
      this.btnFlyttRadNer.Text = "ᐯ";
      this.btnFlyttRadNer.UseVisualStyleBackColor = true;
      this.btnFlyttRadNer.Click += new System.EventHandler(this.btnFlyttRadNer_Click);
      // 
      // btnFlyttRadUpp
      // 
      this.btnFlyttRadUpp.Location = new System.Drawing.Point(518, 384);
      this.btnFlyttRadUpp.Name = "btnFlyttRadUpp";
      this.btnFlyttRadUpp.Size = new System.Drawing.Size(60, 34);
      this.btnFlyttRadUpp.TabIndex = 5;
      this.btnFlyttRadUpp.Text = "ᐱ";
      this.btnFlyttRadUpp.UseVisualStyleBackColor = true;
      this.btnFlyttRadUpp.Click += new System.EventHandler(this.btnFlyttRadUpp_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(656, 430);
      this.Controls.Add(this.btnFlyttRadUpp);
      this.Controls.Add(this.btnFlyttRadNer);
      this.Controls.Add(this.btnStorstMål);
      this.Controls.Add(this.tbxMålrikast);
      this.Controls.Add(this.btnMålrikast);
      this.Controls.Add(this.dgvMatcher);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Button btnFlyttRadUpp;
    private System.Windows.Forms.Button btnFlyttRadNer;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button btnStorstMål;

    private System.Windows.Forms.Button btnMålrikast;
    private System.Windows.Forms.TextBox tbxMålrikast;

    private System.Windows.Forms.DataGridView dgvMatcher;

    private System.Windows.Forms.DataGridViewTextBoxColumn HemmaLag;
    private System.Windows.Forms.DataGridViewTextBoxColumn BortaLag;
    private System.Windows.Forms.DataGridViewTextBoxColumn MålHemmaLag;
    private System.Windows.Forms.DataGridViewTextBoxColumn MålBortaLag;

    #endregion
  }
}

