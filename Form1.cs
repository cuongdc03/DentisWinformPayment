using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Dispose();
        }
        private double Total()
        {
            double s = 0;
            if(checkBox1.Checked)
            {
                s += 100000;
            }
            if (checkBox2.Checked)
                s += 80000;
            if (checkBox3.Checked)
                s += 200000;
            string select = comboBox1.SelectedItem.ToString();
            int rang = Convert.ToInt32(select);
            s += (60000 * rang);
            return s;
        }

        private void button2_Click(object sender, EventArgs e)
        {   if (textBox1.Text == "")
                MessageBox.Show("Nhập tên đi cu");
            else
            textBox2.Text = Convert.ToString(Total());
        }
    }
}
