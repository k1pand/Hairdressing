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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Strizhka";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Strizhka.KodStrizhki= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3]);
            }
            dataGridView1.Refresh();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Код", "Код");
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Пол", "Пол");
            dataGridView1.Columns.Add("Цена", "Цена");
        }
    }
}
