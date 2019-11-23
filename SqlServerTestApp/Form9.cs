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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Количество", "Количество");
            dataGridView1.Columns.Add("Пол", "Пол");

            string query = "select count(Pol), Pol from Client group by Pol  ";

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
