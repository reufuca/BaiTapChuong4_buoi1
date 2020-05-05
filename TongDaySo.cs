using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_part1
{
    public partial class TongDaySo : Form
    {
        public TongDaySo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textsoA_TextChanged(object sender, EventArgs e)
        {

        }



        private void textsoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void textsoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j, sum = 0;
            int a = Convert.ToInt32(textsoA.Text);
            int b = Convert.ToInt32(textsoB.Text);
            if ( a > b ) 
            {
                MessageBox.Show("Vui lòng nhập a nhỏ hơn b");
    
                return;
            }
            label5.Text = a.ToString();
            label6.Text = b.ToString();
            for (j = a; j <= b; j++)
            {
                sum = sum + j;
            }
            label8.Text = sum.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textsoA.ResetText();
            textsoB.ResetText();
            label5.ResetText();
            label6.ResetText();
            label8.ResetText();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
