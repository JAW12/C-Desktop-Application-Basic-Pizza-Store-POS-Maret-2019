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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public static bool openOrderPizza = false;
        private void orderPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.MdiParent = this;
            if (openOrderPizza == false)
            {
                order.Show();
                order.Location = new Point(0, 55);
                openOrderPizza = true;
            }
        }

        public static bool openHistory = false;
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.MdiParent = this;
            if(openHistory == false)
            {
                history.Show();
                history.Location = new Point(0, 55);
                openHistory = true;
            }
        }
    }
}