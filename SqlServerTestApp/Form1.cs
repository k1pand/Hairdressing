﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("№ услуги", "№ услуги");
            dataGridView1.Columns.Add("№ клиента", "№ клиента");
            dataGridView1.Columns.Add("№ мастера", "№ мастера");
            dataGridView1.Columns.Add("№ стрижки", "№ стрижки");
            dataGridView1.Columns.Add("Дата", "Дата");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string query = "select * from  Usluga";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4]);
            }
            dataGridView1.Refresh();
        }
    }
}

