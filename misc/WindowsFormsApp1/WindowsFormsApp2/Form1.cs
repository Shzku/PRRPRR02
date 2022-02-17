using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Kund> kunder = new List<Kund>();
        public Form1()
        {
            InitializeComponent();
        }

        private void kundTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void destTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void antalDTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void bokaButton_Click(object sender, EventArgs e)
        {
            string namn = kundTextBox.Text;
            string destination = destTextBox.Text;
            int antalDagar = int.Parse(antalDTextBox.Text);
            
            kunder.Add(new Kund(namn, destination, antalDagar));
            kundTextBox.Clear();
            destTextBox.Clear();
            antalDTextBox.Clear();
        }

        private void sokNamnTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void sokKundButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void kundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}