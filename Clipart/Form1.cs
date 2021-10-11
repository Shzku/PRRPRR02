using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipart
{
    public partial class Form1 : Form
    {
        private BindingList<Figur> figur = new BindingList<Figur>();
        
        public Form1()
        {
            InitializeComponent();
            figurLBX.DataSource = figur;
            figurLBX.DisplayMember = "Info";
        }

        private void skapaTriBTN_Click(object sender, EventArgs e)
        {
            figur.Add(new Triangel(
                double.Parse(breddTBX.Text), 
                double.Parse(höjdTBX.Text), 
                "Triangel: " + breddTBX.Text + "x" + höjdTBX.Text) );
            
            breddTBX.Clear();
            höjdTBX.Clear();
        }

        private void skapaCirBTN_Click(object sender, EventArgs e)
        {
            figur.Add(new Cirkel(
                double.Parse(breddTBX.Text), 
                double.Parse(höjdTBX.Text), 
                "Cirkel: " + breddTBX.Text + "x" + höjdTBX.Text) );
            
            breddTBX.Clear();
            höjdTBX.Clear();
        }

        private void skapaLinBTN_Click(object sender, EventArgs e)
        {
            figur.Add(new Linje(
                double.Parse(breddTBX.Text), 
                double.Parse(höjdTBX.Text), 
                "Linje: " + breddTBX.Text + "x" + höjdTBX.Text) );
            
            breddTBX.Clear();
            höjdTBX.Clear();
        }

        private void sammanlagBTN_Click(object sender, EventArgs e)
        {
            double totalArea = 0;
            
            foreach (Figur f in figur)
            {
                if (f is IArea)
                {
                    totalArea += (f as IArea).BeräknaArea();
                }
            }

            sammanlagTBX.Clear();
            sammanlagTBX.Text = Convert.ToString(Math.Floor(totalArea) + " cm²");
        }
    }
}