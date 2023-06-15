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
    public partial class Beli_Stock : Form
    {
        public Beli_Stock()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int idxpPizza = cbPizza.SelectedIndex;
            int idxpMeat = cbMeat.SelectedIndex;
            int idxpTopping = cbTopping.SelectedIndex;
            int bayar = 0;
            if(idxpPizza != -1)
            {
                bayar += Form1.HPizza[idxpPizza] * (int)nudPizza.Value;
            }
            if(idxpMeat != -1)
            {
                bayar += Form1.HMeat[idxpMeat] * (int)nudMeat.Value;
            }
            if(idxpTopping != -1)
            {
                bayar += Form1.HTopping[idxpTopping] * (int)nudTopping.Value;
            }
            if (bayar <= Admin.MoneyAdm)
            {
                Admin.MoneyAdm -= bayar;
                Form ff = this.MdiParent;
                Admin admin = (Admin)ff;
                admin.lblMoney.Text = Admin.MoneyAdm.ToString("#,##0");
                if (idxpPizza != -1)
                {
                    Form1.SPizza[idxpPizza] += (int)nudPizza.Value;
                }
                if (idxpMeat != -1)
                {
                    Form1.SMeat[idxpMeat] += (int)nudMeat.Value;
                }
                if (idxpTopping != -1)
                {
                    Form1.STopping[idxpTopping] += (int)nudTopping.Value;
                }
            }
            else
            {
                MessageBox.Show("Uang Tidak Cukup");
            }
            cbPizza.SelectedIndex = -1;
            cbMeat.SelectedIndex = -1;
            cbTopping.SelectedIndex = -1;
            nudPizza.Value = 0;
            nudMeat.Value = 0;
            nudTopping.Value = 0;
        }

        private void Beli_Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin.openBeliStok = false;
        }

        private void Beli_Stock_Move(object sender, EventArgs e)
        {
            Form ff = this.MdiParent;
            Admin admin = (Admin)ff;

            if (this.Location.X >= -780 && this.Location.X <= 185 && this.Location.Y >= -510 && this.Location.Y <= 35)
            {
                admin.lblMoney.Visible = false;
                admin.lblSMoney.Visible = false;
            }
            else
            {
                admin.lblMoney.Visible = true;
                admin.lblSMoney.Visible = true;
            }
        }
    }
}