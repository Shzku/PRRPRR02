using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FotbollsLigan
{
  public partial class Form1 : Form
  {
    private List<Match> matcher = new List<Match>();

    public Form1()
    {
      InitializeComponent();
    }

    private void dgvMatcher_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      Match nyMatch = new Match();
      matcher.Add(nyMatch);
    }

    private void dgvMatcher_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      matcher.RemoveAt(e.Row.Index);
    }
    
    private void dgvMatcher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      int i = e.RowIndex; // Index för den rad som redigerats. 

      if (e.ColumnIndex == 0)
        matcher[i].HemmaLag = (string)dgvMatcher.Rows[i].Cells[0].Value;
      else if (e.ColumnIndex == 1)
        matcher[i].BortaLag = (string)dgvMatcher.Rows[i].Cells[1].Value;
      else if (e.ColumnIndex == 2)
        matcher[i].MålHemmaLag = int.Parse((string)dgvMatcher.Rows[i].Cells[2].Value);
      else if (e.ColumnIndex == 3)
        matcher[i].MålBortaLag = int.Parse((string)dgvMatcher.Rows[i].Cells[3].Value);
    }

    private void btnMålrikast_Click(object sender, EventArgs e)
    {
      string hemmalag = "";
      string bortalag = "";
      int antalMål = 0;
      for (int i = 0; i < matcher.Count; i++)
      {
        if (matcher[i].MålHemmaLag + matcher[i].MålBortaLag > antalMål)
        {
          hemmalag = matcher[i].HemmaLag;
          bortalag = matcher[i].BortaLag;
          antalMål = matcher[i].MålHemmaLag + matcher[i].MålBortaLag;
        }
      }
      tbxMålrikast.Text = hemmalag + " " + bortalag + ": " + antalMål;
    }

    private void btnStorstMål_Click(object sender, EventArgs e)
    {
      string hemmalag = "";
      string bortalag = "";
      int målSkillnad = 0;
      for (int i = 0; i < matcher.Count; i++)
      { 
        if (Math.Abs(matcher[i].MålHemmaLag - matcher[i].MålBortaLag) > målSkillnad)
        {
          hemmalag = matcher[i].HemmaLag;
          bortalag = matcher[i].BortaLag;
          målSkillnad = Math.Abs(matcher[i].MålHemmaLag - matcher[i].MålBortaLag);
        }
      }
      tbxMålrikast.Text = hemmalag + " " + bortalag + ": " + målSkillnad;
    }

    private void btnFlyttRadUpp_Click(object sender, EventArgs e)
    {
      try
      {
        int rowIndex = dgvMatcher.SelectedCells[0].OwningRow.Index;
        if (rowIndex == 0) 
          return;
        DataGridViewRow selectedRow = dgvMatcher.Rows[rowIndex];
        dgvMatcher.Rows.Remove(selectedRow);
        dgvMatcher.Rows.Insert(rowIndex - 1, selectedRow);
      }
      catch { }
    }

    private void btnFlyttRadNer_Click(object sender, EventArgs e)
    {
      try
      {
        int totalRows = dgvMatcher.Rows.Count;
        int rowIndex = dgvMatcher.SelectedCells[0].OwningRow.Index;
        if (rowIndex == totalRows - 1) 
          return;
        DataGridViewRow selectedRow = dgvMatcher.Rows[rowIndex];
        if (rowIndex + 1 >= dgvMatcher.Rows.Count - 1) 
          return;
        dgvMatcher.Rows.Remove(selectedRow);
        dgvMatcher.Rows.Insert(rowIndex + 1, selectedRow);
      }
      catch { }
    }
  }

  public class Match
  {
    public string HemmaLag { get; set; }
    public string BortaLag { get; set; }
    public int MålHemmaLag { get; set; }
    public int MålBortaLag { get; set; }
  }
}
