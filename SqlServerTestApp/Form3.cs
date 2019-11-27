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
            /*Select Filial.KodFiliala, count(Usluga.KodMastera) From Usluga, Filial
Group by Filial.KodFiliala 


Select Usluga.KodClienta, count (KodClienta) From Usluga
WHERE Usluga.Data
between '2019/11/11' and '2019/11/13'
Group by KodClienta
*/
        }
    }
}
