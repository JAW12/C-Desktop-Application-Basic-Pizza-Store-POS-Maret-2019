using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Praktikum_Minggu_4
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public static int MoneyAdm = 1000000;

        public static bool openBeliStok = false;
        private void beliStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beli_Stock beli_stock = new Beli_Stock();
            beli_stock.MdiParent = this;
            if (openBeliStok == false)
            {
                beli_stock.Show();
                beli_stock.Location = new Point(0, 50);
                openBeliStok = true;
            }
        }

        public static bool openLihatStock = false;
        private void lihatStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lihat_Stock lihat_stock = new Lihat_Stock();
            lihat_stock.MdiParent = this;
            if (openLihatStock == false)
            {
                lihat_stock.Show();
                lihat_stock.Location = new Point(0, 50);
                openLihatStock = true;
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblMoney.Text = MoneyAdm.ToString("#,##0");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMoney.Text = MoneyAdm.ToString("#,##0");
        }
    }
}