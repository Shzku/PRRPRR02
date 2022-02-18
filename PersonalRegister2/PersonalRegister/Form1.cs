using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PersonalRegister
{
    public partial class Form1 : Form
    {
        BindingList<Anställd> anställd = new BindingList<Anställd>();
        public int i;
        
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = anställd;
            listBox1.DisplayMember = "Namn";
            listBox2.DataSource = anställd;
        }

        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void label13_Click(object sender, EventArgs e)
        {

        }
        #endregion
        
        private void button1_Click(object sender, EventArgs e)
        {
            string namn;
            double provision;
            double försäljning;
          
            namn = textBox1.Text;
            provision = double.Parse(textBox2.Text);
            försäljning = double.Parse(textBox3.Text);

            anställd.Add(new Säljare(namn + " (Säljare)", provision, försäljning));

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namn;
            double arbetsTid;
            double timLön;
            
            namn = textBox4.Text;
            timLön = double.Parse(textBox5.Text);
            arbetsTid = double.Parse(textBox6.Text);
            
            anställd.Add(new Konsult(namn + " (Konsult)", arbetsTid, timLön));

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string namn;
            double månadsLön;
           

            namn = textBox7.Text;
            månadsLön = double.Parse(textBox8.Text);
            
            anställd.Add(new Kontorist(namn + " (Konsult)", månadsLön));

            textBox7.Clear();
            textBox8.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double totLön = 0;

            foreach(Anställd a in anställd)
            {
                totLön += a.BeräknaLön();
            }

            textBox9.Clear();
            textBox9.Text = Convert.ToString(totLön);
            
        }
    }
}
