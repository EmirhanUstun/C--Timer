using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if(sayac == 5)
            {
                this.BackColor = Color.Red;
            }
            
            if (sayac == 10)
            {
                this.BackColor = Color.Blue;
                sayac = 0;
            }
        }
        int sayac2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            label2.Text = sayac2.ToString();
            if (sayac2 == 2)
            {
                this.BackColor = Color.Red;
            }
            if (sayac2 == 30)
            {
                this.BackColor = Color.Yellow;
                
            }
            if(sayac2 == 40)
            {
                this.BackColor= Color.Green;
            }
            if(sayac2 == 70)
            {
                sayac2 = 0;
            }
        }
    }
    }

