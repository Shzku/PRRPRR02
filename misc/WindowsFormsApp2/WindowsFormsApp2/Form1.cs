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
        public Form1()
        {
            InitializeComponent();
            
            Cykel cykel1 = new Cykel(1, 4);
            Cykel cykel2 = new Cykel(2, 6);
            Personbil personbil1 = new Personbil(1, "HejHej", 4);
            Personbil personbil2 = new Personbil(2, "ByeBye", 6);
            Personbil personbil3 = new Personbil(1, "Sport", 2);
            Lastbil lastbil1 = new Lastbil(1, "Tung", 220);
            Lastbil lastbil2 = new Lastbil(2, "Snabb", 120);

            listBox1.Items.Add(cykel1.nyUtskrift());
            listBox1.Items.Add(cykel2.nyUtskrift());
            listBox1.Items.Add(personbil1.nyyUtskrift());
            listBox1.Items.Add(personbil2.nyyUtskrift());
            listBox1.Items.Add(lastbil1.nyyUtskrift());
            listBox1.Items.Add(lastbil2.nyyUtskrift());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}