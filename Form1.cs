using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbkurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void z1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCONST newForm = new FormCONST();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCHANGE newForm = new FormCHANGE();
            newForm.Show();
        }
    }
}
