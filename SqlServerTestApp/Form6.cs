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
        public class IdentityItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public IdentityItem(string id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int? familia = null;
            int? imya = null;
            int? otchestvo = null;
            int? pol = null;
            DateTime date;

            try
            {
                familia = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
                imya = Convert.ToInt32((comboBox2.SelectedItem as IdentityItem)?.Id);
                otchestvo = Convert.ToInt32((comboBox3.SelectedItem as IdentityItem)?.Id);
                pol = Convert.ToInt32((comboBox4.SelectedItem as IdentityItem)?.Id);
                date = dateTimePicker1.Value;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "insert into Client (Familia, Imya, Otchestvo, Pol, Data) " +
                "values (" + $"'{familia}','{imya}','{otchestvo}', '{pol}', '{date}'" + ")";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Выполнено", "Запись сохранена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select Client.Familia, Client.Familia from Client";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(s => new IdentityItem(s[0], s[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select Client.Imya, Client.Imya from Client";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(s => new IdentityItem(s[0], s[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            string query = "select Client.Otchestvo, Client.Otchestvo from Client";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(s => new IdentityItem(s[0], s[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            string query = "select Client.Pol, Client.Pol from Client";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(s => new IdentityItem(s[0], s[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }
    }
}
