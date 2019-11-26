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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Client ";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Client.KodClienta= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4], l[5]);
            }
            dataGridView1.Refresh();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Код", "Код");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Пол", "Пол");
            dataGridView1.Columns.Add("Дата", "Дата");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны строки для удаления.");
            }
            // this overcomes the out of bound error message 
            // if the selectedRow is greater than 0 then exectute the code below. 
            if (dataGridView1.CurrentCell.RowIndex > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                // gets the RowID from the first column in the grid 
                int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                // Prepare the command text with the parameter placeholder 
                string sql = "DELETE FROM Client WHERE KodClienta = "+rowID;

                // Add the parameter to the command collection 
                int? result = DBConnectionService.SendCommandToSqlServer(sql);

                // Remove the row from the grid 
                if (result != null && result > 0)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
            }
        }
    }
}
