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

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Код", "Код");
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Пол", "Пол");
            dataGridView1.Columns.Add("Цена", "Цена");

            string query = "select * from Strizhka";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3]);
            }
            dataGridView1.Refresh();
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
                string sql = "DELETE FROM Strizhka WHERE KodStrizhki = " + rowID;

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
        private void button1_Click(object sender, EventArgs e)
        {
            int? nazvanie = null;
            int? pol = null;
            int? stoimost = null;

            try
            {
                nazvanie = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
                pol = Convert.ToInt32((comboBox2.SelectedItem as IdentityItem)?.Id);
                stoimost = Convert.ToInt32((comboBox3.SelectedItem as IdentityItem)?.Id);
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "insert into Strizhka (KodStrizhki, Nazvanie, Pol, Stoimost) " +
                "values (" + $" '{nazvanie}', '{pol}', '{stoimost}'" + ")";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Выполнено", "Запись сохранена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select Strizhka.Nazvanie, Strizhka.Nazvanie from Strizhka";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(s => new IdentityItem(s[0], s[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            var list = (new List<IdentityItem>() { new IdentityItem("Муж", "Муж"), new IdentityItem("Жен", "Жен") }).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            string query = "select Strizhka.Stoimost, Strizhka.Stoimost from Strizhka";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(s => new IdentityItem(s[0], s[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }
    }
}