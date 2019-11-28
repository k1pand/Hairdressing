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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Клиент", "Клиент");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select c.Familia + ' '+c.Imya + ' '+c.Otchestvo + '' from (select Usluga.KodClienta as id, count(Usluga.KodClienta) as c From Usluga, [dbo].[Client] WHERE(Usluga.Data between DATEADD(month, -1, GETDATE()) and GETDATE()) and[dbo].[Client].KodClienta = Usluga.KodClienta Group by Usluga.KodClienta) as q, [dbo].[Client] as c where q.id = c.KodClienta ";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0]);
            }
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select c.Familia + ' '+c.Imya + ' '+c.Otchestvo + '' from (select Usluga.KodClienta as id, count(Usluga.KodClienta) as c From Usluga, [dbo].[Client] WHERE(Usluga.Data between DATEADD(week, -1, GETDATE()) and GETDATE()) and[dbo].[Client].KodClienta = Usluga.KodClienta Group by Usluga.KodClienta) as q, [dbo].[Client] as c where q.id = c.KodClienta ";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0]);
            }
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Select c.Familia + ' '+c.Imya + ' '+c.Otchestvo + '' from (select Usluga.KodClienta as id, count(Usluga.KodClienta) as c From Usluga, [dbo].[Client] WHERE(Usluga.Data between DATEADD(day, -2, GETDATE()) and GETDATE()) and[dbo].[Client].KodClienta = Usluga.KodClienta Group by Usluga.KodClienta) as q, [dbo].[Client] as c where q.id = c.KodClienta ";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0]);
            }
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "Select c.Familia + ' '+c.Imya + ' '+c.Otchestvo + '' from (select Usluga.KodClienta as id, count(Usluga.KodClienta) as c From Usluga, [dbo].[Client] WHERE(Usluga.Data between DATEADD(hour, -25, GETDATE()) and GETDATE()) and[dbo].[Client].KodClienta = Usluga.KodClienta Group by Usluga.KodClienta) as q, [dbo].[Client] as c where q.id = c.KodClienta ";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0]);
            }
            dataGridView1.Refresh();
        }
    }
}
