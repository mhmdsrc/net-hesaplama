using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double matDogru, matYanlıs, turkceDogru, turkceYanlıs, matNet, turkceNet;
            matDogru = Convert.ToDouble(textBox1.Text);
            matYanlıs = Convert.ToDouble(textBox2.Text);
            matNet = (matDogru - (matYanlıs / 4));
            textBox5.Text = matNet.ToString();

            turkceDogru = Convert.ToDouble(textBox3.Text);
            turkceYanlıs = Convert.ToDouble(textBox4.Text);
            turkceNet = (turkceDogru - (turkceYanlıs / 4));
            textBox6.Text = turkceNet.ToString();

        }
    }
}
