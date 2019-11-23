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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Код", "Код");
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Адрес", "Адрес");
            dataGridView1.Columns.Add("Телефон", "Телефон");

            string query = "select * from Filial ";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3]);
            }
            dataGridView1.Refresh();
        }
    }
}
