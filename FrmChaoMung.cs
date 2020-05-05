using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_part1
{
    public partial class FrmChaoMung : Form
    {
        public FrmChaoMung()
        {
            InitializeComponent();
        }

       /* private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên");
                textBox2.Focus();
                return;
            }
            if (textBox4.Text == "") ;
            {
                MessageBox.Show("Bạn chưa nhập lớp");
                textBox4.Focus();
                return;
            }
            MessageBox.Show("Chào mừng bạn  " + textBox2.Text + "học lớp" + textBox4.Text);
        }

        private void FrmChaoMung_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } */

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên");
                txtTen.Focus();
                return;
            }
            if (txtLop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Lớp");
                txtLop.Focus();
                return;
            }
            MessageBox.Show("Chào mừng " + txtTen.Text + " học lớp " + txtLop.Text);
        }
    }
}
