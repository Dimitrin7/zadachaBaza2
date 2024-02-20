using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data1DataSet1.Таблица1' table. You can move, or remove it, as needed.
           // this.таблица1TableAdapter1.Fill(this.data1DataSet1.Таблица1);
            // TODO: This line of code loads data into the 'data1DataSet.Таблица1' table. You can move, or remove it, as needed.
          //  this.таблица1TableAdapter.Fill(this.data1DataSet.Таблица1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_Click(object sender, EventArgs e)
        {
            this.таблица1TableAdapter.Fill(this.data1DataSet.Таблица1);
            data1DataSet.Таблица1.AddТаблица1Row(textBox1.Text, textBox2.Text,textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.MoveNext();
            таблица1BindingSource.EndEdit();
           // таблица1TableAdapter.Update(data1DataSet.Таблица1);
            MessageBox.Show("Saved!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            таблица1BindingSource.MoveNext();
            таблица1BindingSource.EndEdit();
            // таблица1TableAdapter.Update(data1DataSet.Таблица1);
            MessageBox.Show("Saved!");
        }
    }
}
