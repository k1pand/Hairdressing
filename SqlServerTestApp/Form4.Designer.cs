﻿namespace SqlServerTestApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filialBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.filialBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.filialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nazvanieFilialaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieFilialaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Код мастера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Код стрижки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Внести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filialBindingSource3
            // 
            this.filialBindingSource3.DataMember = "Filial";
            // 
            // filialBindingSource2
            // 
            this.filialBindingSource2.DataMember = "Filial";
            // 
            // filialBindingSource1
            // 
            this.filialBindingSource1.DataMember = "Filial";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(230, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.DropDown += new System.EventHandler(this.comboBox3_DropDown);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(333, 42);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(97, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 392);
            this.dataGridView1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Показать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(606, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form4";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazvanieFilialaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource filialBindingSource1;
        private System.Windows.Forms.BindingSource filialBindingSource3;
        private System.Windows.Forms.BindingSource filialBindingSource2;
        private System.Windows.Forms.BindingSource nazvanieFilialaBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}