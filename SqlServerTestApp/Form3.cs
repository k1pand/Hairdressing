using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form8().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form9().Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form10().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form11().Show();
        }
    }
}
