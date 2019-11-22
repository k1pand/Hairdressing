using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "select * from Masteri ";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Masteri.KodMastera = '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4], l[5]);
            }
            dataGridView1.Refresh();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
                dataGridView1.Columns.Add("Код", "Код");
                dataGridView1.Columns.Add("Филиал", "Филиал");
                dataGridView1.Columns.Add("Фамилия", "Фамилия");
                dataGridView1.Columns.Add("Имя", "Имя");
                dataGridView1.Columns.Add("Отчество", "Отчество");
                dataGridView1.Columns.Add("Телефон", "Телефон");
        }
    }
}

