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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Филиал", "Филиал");
            dataGridView1.Columns.Add("Количество", "Количество");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select Filial.KodFiliala, count(Usluga.KodMastera) From Usluga, Filial, Masteri where Usluga.KodMastera = Masteri.KodMastera and Masteri.KodFiliala = Filial.KodFiliala Group by Filial.KodFiliala ";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1]);
            }
            dataGridView1.Refresh();
        }
    }
}
