using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            int? client = null;
            int? filial = null;
            int? master = null;
            int? strizhka = null;
            DateTime date;

            try
            {
                client = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
                master = Convert.ToInt32((comboBox3.SelectedItem as IdentityItem)?.Id);
                strizhka = Convert.ToInt32((comboBox4.SelectedItem as IdentityItem)?.Id);
                date = dateTimePicker1.Value;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "insert into Usluga (KodClienta, KodMastera, KodStrizhki, Data)" +
                "values (" + $"'{client}','{master}','{strizhka}', '{date}'" + ");";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Saving object", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }
    }
}