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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void chàoMừngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaoMung c1 = new FrmChaoMung();
            c1.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTong c2 = new TinhTong();
            c2.Show();
        }

        private void tổngDãySốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongDaySo c3 = new TongDaySo();
            c3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
