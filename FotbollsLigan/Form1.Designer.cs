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
      this.dgvMatcher.Size = new System.Drawing.Size(538, 346);
      this.dgvMatcher.TabIndex = 0;
      this.dgvMatcher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatcher_CellEndEdit);
      this.dgvMatcher.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMatcher_UserAddedRow);
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
      this.btnMålrikast.Size = new System.Drawing.Size(174, 27);
      this.btnMålrikast.TabIndex = 1;
      this.btnMålrikast.Text = "Målrikast";
      this.btnMålrikast.UseVisualStyleBackColor = true;
      this.btnMålrikast.Click += new System.EventHandler(this.btnMålrikast_Click);
      // 
      // tbxMålrikast
      // 
      this.tbxMålrikast.Location = new System.Drawing.Point(187, 361);
      this.tbxMålrikast.Name = "tbxMålrikast";
      this.tbxMålrikast.Size = new System.Drawing.Size(358, 22);
      this.tbxMålrikast.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(585, 409);
      this.Controls.Add(this.tbxMålrikast);
      this.Controls.Add(this.btnMålrikast);
      this.Controls.Add(this.dgvMatcher);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dgvMatcher)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

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

