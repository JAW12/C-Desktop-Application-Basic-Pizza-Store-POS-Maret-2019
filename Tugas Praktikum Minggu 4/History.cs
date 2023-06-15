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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        Image Pizza;
        Image Meat;
        int xMeat, yMeat;
        Image Pepper;
        int xPepper, yPepper;
        Image Mushroom;
        int xMushroom, yMushroom;
        Image Tomatoes;
        int xTomatoes, yTomatoes;
        Image Pineapple;

        private void History_Load(object sender, EventArgs e)
        {
            lbKode.Items.Clear();
            for(int i = 0;i < Form1.OKCustomer[Login.loginCustomer].Count(); i++)
            {
                lbKode.Items.Add(Form1.OKCustomer[Login.loginCustomer][i].ToString());
            }
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Customer.openHistory = false;
        }

        private void History_Move(object sender, EventArgs e)
        {
            Form ff = this.MdiParent;
            Customer customer = (Customer)ff;
            if (this.Location.X >= -950 && this.Location.X <= 1200 && this.Location.Y >= -700 && this.Location.Y <= 50)
            {
                customer.lblJudul.Visible = false;
            }
            else
            {
                customer.lblJudul.Visible = true;
            }
        }

        int xPineapple, yPineapple;
        int ukuranP;

        private void History_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (Pizza != null)
            {
                g.DrawImage(Pizza, 275, 50, ukuranP, ukuranP);
            }
            if (Meat != null)
            {
                g.DrawImage(Meat, xMeat, yMeat, 50, 50);
            }
            if (Pepper != null)
            {
                g.DrawImage(Pepper, xPepper, yPepper, 50, 50);
            }
            if (Mushroom != null)
            {
                g.DrawImage(Mushroom, xMushroom, yMushroom, 50, 50);
            }
            if (Tomatoes != null)
            {
                g.DrawImage(Tomatoes, xTomatoes, yTomatoes, 50, 50);
            }
            if (Pineapple != null)
            {
                g.DrawImage(Pineapple, xPineapple, yPineapple, 50, 50);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(lbKode.SelectedIndex != -1)
            {
                Pizza = Form1.OPCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                ukuranP = Form1.OSCustomer[Login.loginCustomer][lbKode.SelectedIndex];

                Meat = Form1.OMCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                xMeat = Form1.OXMCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                yMeat = Form1.OYMCustomer[Login.loginCustomer][lbKode.SelectedIndex];

                Pepper = Form1.OPepperCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                xPepper = Form1.OXPepperCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                yPepper = Form1.OYPepperCustomer[Login.loginCustomer][lbKode.SelectedIndex];

                Mushroom = Form1.OMushroomCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                xMushroom = Form1.OXMushroomCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                yMushroom = Form1.OYMushroomCustomer[Login.loginCustomer][lbKode.SelectedIndex];

                Tomatoes = Form1.OTomatoesCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                xTomatoes = Form1.OXTomatoesCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                yTomatoes = Form1.OYTomatoesCustomer[Login.loginCustomer][lbKode.SelectedIndex];

                Pineapple = Form1.OPineappleCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                xPineapple = Form1.OXPineappleCustomer[Login.loginCustomer][lbKode.SelectedIndex];
                yPineapple = Form1.OYPineappleCustomer[Login.loginCustomer][lbKode.SelectedIndex];

                lblTotal.Text = Form1.OHCustomer[Login.loginCustomer][lbKode.SelectedIndex].ToString("#,##0");
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Kode Pizza Belum Dipilih");
            }
        }
    }
}