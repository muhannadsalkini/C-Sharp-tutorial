using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_formApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doktor.Checked == true)
                textBox1.Text = "Doktor checked";
            else if (polis.Checked == true)
                textBox1.Text = "Polis checked";
            else if (engneer.Checked == true)
                textBox1.Text = "Engneer checked";
            else if (ogretmen.Checked == true)
                textBox1.Text = "Ogretmen checked";
            else textBox1.Text = "empty!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
