using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiMauName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Pink;
            textBox1.ForeColor = Color.Pink;
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    textBox2.ForeColor = Color.Pink;
                    textBox1.ForeColor = Color.Pink;
                    break;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Red;
            textBox1.ForeColor = Color.Red;
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    textBox2.ForeColor = Color.Red;
                    textBox1.ForeColor = Color.Red;
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            textBox1.Text = textBox2.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Green;
            textBox1.ForeColor = Color.Green;
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    textBox2.ForeColor = Color.Green;
                    textBox1.ForeColor = Color.Green;
                    break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    textBox2.ForeColor = Color.Black;
                    textBox1.ForeColor = Color.Black;
                    break;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            {
                textBox2.ForeColor = Color.Blue;
                textBox1.ForeColor = Color.Blue;
                RadioButton r = (RadioButton)sender;
                switch (r.Name)
                {
                    case "radRed":
                        textBox2.ForeColor = Color.Blue;
                        textBox1.ForeColor = Color.Blue;
                        break;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Silver;
            textBox1.ForeColor = Color.Silver;
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    textBox2.ForeColor = Color.Silver;
                    textBox1.ForeColor = Color.Silver;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}