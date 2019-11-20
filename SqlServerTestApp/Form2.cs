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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string datasource = textBox1.Text;
            string database = textBox2.Text;
            string username = textBox3.Text ?? "";
            string userpass = textBox4.Text ?? "";

            if (string.IsNullOrEmpty(datasource) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Ошибка! Не все поля заполнены.", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBConnectionService.SetSqlConnection(GetDBConnectionString(datasource, database, username, userpass)))
            {
                MessageBox.Show("Выполнено!", "Соединение подключено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public string GetDBConnectionString(string datasource, string database, string username, string password)
        {
            string dataSourceStirng = "Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;";
            if (!string.IsNullOrEmpty(username))
            {
                dataSourceStirng += "User ID=" + username + ";Password=" + password + ";";
            }
            else
            {
                dataSourceStirng += "Integrated Security=SSPI;";
            }
            return dataSourceStirng;
        }
        private void DBConnectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }

}


