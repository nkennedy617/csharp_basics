using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add the following code
            //to fill the comboBox when 
            //form loads.

            comboBox1.Items.Add("Dr.");
            comboBox1.Items.Add("Mr.");
            comboBox1.Items.Add("Mrs.");
            comboBox1.Items.Add("Ms.");
            comboBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text + " " +
                textBox1.Text + " " + textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
