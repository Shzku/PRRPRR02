using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Upp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //List<Anställd> anställd = new List<Anställd>();
        public int i;
       

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

        private void button1_Click(object sender, EventArgs e)
        {
            string namn;
            double provision;
            double försäljning;
          
            namn = textBox1.Text;
            provision = double.Parse(textBox2.Text);
            försäljning = double.Parse(textBox3.Text);

            
            //anställd.Add(new Säljare(namn, provision, försäljning));
            //i = anställd.Count - 1;
            //listBox1.Items.Add(anställd[i].ToString(namn));
            //listBox2.Items.Add(anställd[i].ToString(namn) + anställd[i].BeräknaLön());


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namn;
            double timLön;
            double arbetsTid;
            

            namn = textBox4.Text;
            timLön = double.Parse(textBox5.Text);
            arbetsTid = double.Parse(textBox6.Text);
            
            

            //anställd.Add(new Konsult(namn, timLön, arbetsTid));
            //i = anställd.Count - 1;
            //listBox1.Items.Add(anställd[i].ToString(namn));
            //listBox2.Items.Add(anställd[i].ToString(namn) + anställd[i].BeräknaLön());


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
            

            //anställd.Add(new Kontorist(namn, månadsLön));
            //i = anställd.Count - 1;
            //listBox1.Items.Add(anställd[i].ToString(namn));
            //listBox2.Items.Add(anställd[i].ToString(namn) + anställd[i].BeräknaLön());
           

            textBox7.Clear();
            textBox8.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double totLön = 0;
            
            //foreach(Anställd a in anställd)
            //{
            //    if(a is Säljare)
            //    {
            //        totLön += a.BeräknaLön();
            //    }
            //    if(a is Konsult)
            //    {
            //        totLön += a.BeräknaLön();
            //    }
            //    if(a is Kontorist)
            //    {
            //        totLön += a.BeräknaLön();
            //    }
            //}

            listBox3.Items.Clear();
            listBox3.Items.Add(totLön);
            
        }
    }
}
