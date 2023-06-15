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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        double size;
        int ukuranP;
        int totalHarga = 0;
        int hargaPizza = 0;
        bool cukupPizza = true;
        bool cukupMeat = true;
        bool cukupTopping = true;

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
        int xPineapple, yPineapple;

        Random rnd = new Random();

        private void btnOrder_Click(object sender, EventArgs e)
        {
            xMeat = 0;
            yMeat = 0;
            xPepper = 0;
            yPepper = 0;
            xMushroom = 0;
            yMushroom = 0;
            xTomatoes = 0;
            yTomatoes = 0;
            xPineapple = 0;
            yPineapple = 0;

            cukupPizza = true;
            cukupMeat = true;
            cukupTopping = true;
            totalHarga = 0;
            Pizza = null;
            Meat = null;
            Pepper = null;
            Mushroom = null;
            Tomatoes = null;
            Pineapple = null;
            string Orderan = "";
            string nl = Environment.NewLine;
            if(cbPizza.SelectedIndex != -1)
            {
                if(cbPizza.SelectedIndex == 0)
                {
                    if(Form1.SPizza[cbPizza.SelectedIndex] <= 0)
                    {
                        cukupPizza = false;
                    }
                }
                else if(cbPizza.SelectedIndex == 1)
                {
                    if (Form1.SPizza[cbPizza.SelectedIndex] <= 0)
                    {
                        cukupPizza = false;
                    }
                }

                if(cbMeat.SelectedIndex != -1)
                {
                    if(cbMeat.SelectedIndex == 0)
                    {
                        if (Form1.SMeat[cbMeat.SelectedIndex] <= 0)
                        {
                            cukupMeat = false;
                        }
                    }
                    else if(cbMeat.SelectedIndex == 1)
                    {
                        if (Form1.SMeat[cbMeat.SelectedIndex] <= 0)
                        {
                            cukupMeat = false;
                        }
                    }
                    else if(cbMeat.SelectedIndex == 2)
                    {
                        if (Form1.SMeat[cbMeat.SelectedIndex] <= 0)
                        {
                            cukupMeat = false;
                        }
                    }
                }

                if (chbPepper.Checked)
                {
                    if(Form1.STopping[0] <= 0)
                    {
                        cukupTopping = false;
                    }
                }
                if (chbMushroom.Checked)
                {
                    if (Form1.STopping[1] <= 0)
                    {
                        cukupTopping = false;
                    }
                }
                if (chbTomatoes.Checked)
                {
                    if (Form1.STopping[2] <= 0)
                    {
                        cukupTopping = false;
                    }
                }
                if (chbPineapple.Checked)
                {
                    if (Form1.STopping[3] <= 0)
                    {
                        cukupTopping = false;
                    }
                }
                if (cukupPizza && cukupMeat && cukupTopping)
                {
                    if (cbPizza.SelectedIndex != -1)
                    {
                        Orderan += "Nama Customer : " + Form1.Customer[Login.loginCustomer][0] + nl;
                        Form1.OKCustomer[Login.loginCustomer].Add(lblKode.Text.ToString());
                        Orderan += "=====================================" + nl;
                        Orderan += "Kode : " + lblKode.Text + nl;
                        if (cbPizza.SelectedIndex == 0)
                        {
                            if (Form1.SPizza[cbPizza.SelectedIndex] > 0)
                            {
                                Pizza = Image.FromFile("plain pizza.png");
                                totalHarga += Form1.HPizza[cbPizza.SelectedIndex];
                                hargaPizza = Form1.HPizza[cbPizza.SelectedIndex];
                                Form1.SPizza[cbPizza.SelectedIndex]--;
                                cbPizza.Items[cbPizza.SelectedIndex] = Form1.NPizza[cbPizza.SelectedIndex] + " - " + Form1.SPizza[cbPizza.SelectedIndex];
                                Orderan += "Base Pizza : " + Form1.NPizza[cbPizza.SelectedIndex] + nl;
                            }
                        }
                        else if (cbPizza.SelectedIndex == 1)
                        {
                            if (Form1.SPizza[cbPizza.SelectedIndex] > 0)
                            {
                                Pizza = Image.FromFile("black pizza.png");
                                totalHarga += Form1.HPizza[cbPizza.SelectedIndex];
                                hargaPizza = Form1.HPizza[cbPizza.SelectedIndex];
                                Form1.SPizza[cbPizza.SelectedIndex]--;
                                cbPizza.Items[cbPizza.SelectedIndex] = Form1.NPizza[cbPizza.SelectedIndex] + " - " + Form1.SPizza[cbPizza.SelectedIndex];
                                Orderan += "Base Pizza : " + Form1.NPizza[cbPizza.SelectedIndex] + nl;
                            }
                        }
                        Form1.OPCustomer[Login.loginCustomer].Add(Pizza);

                        if (cbMeat.SelectedIndex != -1)
                        {
                            if (cbMeat.SelectedIndex == 0)
                            {
                                if (Form1.SMeat[cbMeat.SelectedIndex] > 0)
                                {
                                    Meat = Image.FromFile("beef.png");
                                    totalHarga += Form1.HMeat[cbMeat.SelectedIndex];
                                    Form1.SMeat[cbMeat.SelectedIndex]--;
                                    cbMeat.Items[cbMeat.SelectedIndex] = Form1.NMeat[cbMeat.SelectedIndex] + " - " + Form1.SMeat[cbMeat.SelectedIndex];
                                    Orderan += "Meat : " + Form1.NMeat[cbMeat.SelectedIndex] + nl;
                                }
                            }
                            else if (cbMeat.SelectedIndex == 1)
                            {
                                if (Form1.SMeat[cbMeat.SelectedIndex] > 0)
                                {
                                    Meat = Image.FromFile("chicken.png");
                                    totalHarga += Form1.HMeat[cbMeat.SelectedIndex];
                                    Form1.SMeat[cbMeat.SelectedIndex]--;
                                    cbMeat.Items[cbMeat.SelectedIndex] = Form1.NMeat[cbMeat.SelectedIndex] + " - " + Form1.SMeat[cbMeat.SelectedIndex];
                                    Orderan += "Meat : " + Form1.NMeat[cbMeat.SelectedIndex] + nl;
                                }
                            }
                            else if (cbMeat.SelectedIndex == 2)
                            {
                                if (Form1.SMeat[cbMeat.SelectedIndex] > 0)
                                {
                                    Meat = Image.FromFile("shrimp.png");
                                    totalHarga += Form1.HMeat[cbMeat.SelectedIndex];
                                    Form1.SMeat[cbMeat.SelectedIndex]--;
                                    cbMeat.Items[cbMeat.SelectedIndex] = Form1.NMeat[cbMeat.SelectedIndex] + " - " + Form1.SMeat[cbMeat.SelectedIndex];
                                    Orderan += "Meat : " + Form1.NMeat[cbMeat.SelectedIndex] + nl;
                                }
                            }
                        }
                        Form1.OMCustomer[Login.loginCustomer].Add(Meat);
                        if (chbPepper.Checked || chbMushroom.Checked || chbTomatoes.Checked || chbPineapple.Checked)
                        {
                            Orderan += "Topping : " + nl;
                            if (chbPepper.Checked)
                            {
                                if (Form1.STopping[0] > 0)
                                {
                                    Pepper = Image.FromFile("pepper.png");
                                    totalHarga += Form1.HTopping[0];
                                    Form1.STopping[0]--;
                                    chbPepper.Text = Form1.NTopping[0] + " - " + Form1.STopping[0];
                                    Orderan += Form1.NTopping[0] + nl;
                                }
                            }
                            if (chbMushroom.Checked)
                            {
                                if (Form1.STopping[1] > 0)
                                {
                                    Mushroom = Image.FromFile("mushroom.png");
                                    totalHarga += Form1.HTopping[1];
                                    Form1.STopping[1]--;
                                    chbMushroom.Text = Form1.NTopping[1] + " - " + Form1.STopping[1];
                                    Orderan += Form1.NTopping[1] + nl;
                                }
                            }
                            if (chbTomatoes.Checked)
                            {
                                if (Form1.STopping[2] > 0)
                                {
                                    Tomatoes = Image.FromFile("tomatoes.png");
                                    totalHarga += Form1.HTopping[2];
                                    Form1.STopping[2]--;
                                    chbTomatoes.Text = Form1.NTopping[2] + " - " + Form1.STopping[2];
                                    Orderan += Form1.NTopping[2] + nl;
                                }
                            }
                            if (chbPineapple.Checked)
                            {
                                if (Form1.STopping[3] > 0)
                                {
                                    Pineapple = Image.FromFile("pineapple.png");
                                    totalHarga += Form1.HTopping[3];
                                    Form1.STopping[3]--;
                                    chbPineapple.Text = Form1.NTopping[3] + " - " + Form1.STopping[3];
                                    Orderan += Form1.NTopping[3] + nl;
                                }
                            }
                        }
                        
                        Form1.OPepperCustomer[Login.loginCustomer].Add(Pepper);
                        Form1.OMushroomCustomer[Login.loginCustomer].Add(Mushroom);
                        Form1.OTomatoesCustomer[Login.loginCustomer].Add(Tomatoes);
                        Form1.OPineappleCustomer[Login.loginCustomer].Add(Pineapple);

                        if (rbSmall.Checked)
                        {
                            ukuranP = 200;
                            xMeat = rnd.Next(325, 400);
                            yMeat = rnd.Next(100, 175);
                            xPepper = rnd.Next(325, 400);
                            yPepper = rnd.Next(100, 175);
                            xMushroom = rnd.Next(325, 400);
                            yMushroom = rnd.Next(100, 175);
                            xTomatoes = rnd.Next(325, 400);
                            yTomatoes = rnd.Next(100, 175);
                            xPineapple = rnd.Next(325, 400);
                            yPineapple = rnd.Next(100, 175);
                            size = 0.25;
                            Orderan += "Ukuran : Small" +  nl;
                        }
                        else if (rbMedium.Checked)
                        {
                            ukuranP = 300;
                            xMeat = rnd.Next(325,500);
                            yMeat = rnd.Next(100, 275);
                            xPepper = rnd.Next(325, 500);
                            yPepper = rnd.Next(100, 275);
                            xMushroom = rnd.Next(325, 500);
                            yMushroom = rnd.Next(100, 275);
                            xTomatoes = rnd.Next(325, 500);
                            yTomatoes = rnd.Next(100, 275);
                            xPineapple = rnd.Next(325, 500);
                            yPineapple = rnd.Next(100, 275);
                            size = 0.5;
                            Orderan += "Ukuran : Medium" + nl;
                        }
                        else if (rbLarge.Checked)
                        {
                            ukuranP = 400;
                            xMeat = rnd.Next(325, 600);
                            yMeat = rnd.Next(100, 375);
                            xPepper = rnd.Next(325, 600);
                            yPepper = rnd.Next(100, 375);
                            xMushroom = rnd.Next(325, 600);
                            yMushroom = rnd.Next(100, 375);
                            xTomatoes = rnd.Next(325, 600);
                            yTomatoes = rnd.Next(100, 375);
                            xPineapple = rnd.Next(325, 600);
                            yPineapple = rnd.Next(100, 375);
                            size = 0.75;
                            Orderan += "Ukuran : Large" + nl;
                        }
                        Form1.OXMCustomer[Login.loginCustomer].Add(xMeat);
                        Form1.OYMCustomer[Login.loginCustomer].Add(yMeat);
                        Form1.OXPepperCustomer[Login.loginCustomer].Add(xPepper);
                        Form1.OYPepperCustomer[Login.loginCustomer].Add(yPepper);
                        Form1.OXMushroomCustomer[Login.loginCustomer].Add(xMushroom);
                        Form1.OYMushroomCustomer[Login.loginCustomer].Add(yMushroom);
                        Form1.OXTomatoesCustomer[Login.loginCustomer].Add(xTomatoes);
                        Form1.OYTomatoesCustomer[Login.loginCustomer].Add(yTomatoes);
                        Form1.OXPineappleCustomer[Login.loginCustomer].Add(xPineapple);
                        Form1.OYPineappleCustomer[Login.loginCustomer].Add(yPineapple);

                        Form1.OSCustomer[Login.loginCustomer].Add(ukuranP);
                        totalHarga += (int)(hargaPizza * size);
                        Orderan += "Total Harga : " + totalHarga.ToString("#,##0") + nl;
                        lblTotal.Text = totalHarga.ToString("#,##0");
                        Admin.MoneyAdm += totalHarga;
                        Form1.OHCustomer[Login.loginCustomer].Add(totalHarga);
                        MessageBox.Show(Orderan);
                        Form1.OKodeCustomer[Login.loginCustomer]++;
                        if (Form1.OKodeCustomer[Login.loginCustomer] < 10)
                        {
                            lblKode.Text = "PIZZA00" + Form1.OKodeCustomer[Login.loginCustomer];
                        }
                        else if (Form1.OKodeCustomer[Login.loginCustomer] < 100)
                        {
                            lblKode.Text = "PIZZA0" + Form1.OKodeCustomer[Login.loginCustomer];
                        }
                        else if (Form1.OKodeCustomer[Login.loginCustomer] < 1000)
                        {
                            lblKode.Text = "PIZZA" + Form1.OKodeCustomer[Login.loginCustomer];
                        }
                        this.Invalidate();
                    }
                }
                else
                {
                    string StokHabis = "";
                    if (!cukupPizza)
                    {
                        StokHabis += Form1.NPizza[cbPizza.SelectedIndex] + nl;
                    }
                    if (!cukupMeat)
                    {
                        StokHabis += Form1.NMeat[cbMeat.SelectedIndex] + nl;
                    }
                    if (!cukupTopping)
                    {
                        if (chbPepper.Checked)
                        {
                            StokHabis += Form1.NTopping[0] + nl;
                        }
                        if (chbMushroom.Checked)
                        {
                            StokHabis += Form1.NTopping[1] + nl;
                        }
                        if (chbTomatoes.Checked)
                        {
                            StokHabis += Form1.NTopping[2] + nl;
                        }
                        if (chbPineapple.Checked)
                        {
                            StokHabis += Form1.NTopping[3] + nl;
                        }
                    }
                    MessageBox.Show("DAFTAR STOK YANG HABIS" + nl + "======================" + nl + StokHabis); ;
                }
            }
            cbMeat.SelectedIndex = -1;
            rbSmall.Checked = true;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            chbPepper.Checked = false;
            chbMushroom.Checked = false;
            chbTomatoes.Checked = false;
            chbPineapple.Checked = false;
        }

        int limitTopping;
        int ctrTopping;
        private void Order_Load(object sender, EventArgs e)
        {
            if (Form1.OKodeCustomer[Login.loginCustomer] < 10)
            {
                lblKode.Text = "PIZZA00" + Form1.OKodeCustomer[Login.loginCustomer];
            }
            else if (Form1.OKodeCustomer[Login.loginCustomer] < 100)
            {
                lblKode.Text = "PIZZA0" + Form1.OKodeCustomer[Login.loginCustomer];
            }
            else if (Form1.OKodeCustomer[Login.loginCustomer] < 1000)
            {
                lblKode.Text = "PIZZA" + Form1.OKodeCustomer[Login.loginCustomer];
            }
            cbPizza.Items.Clear();
            for (int i = 0; i < Form1.NPizza.Count(); i++)
            {
                cbPizza.Items.Add(Form1.NPizza[i] + " - " + Form1.SPizza[i]);
            }
            cbPizza.SelectedIndex = 0;
            rbSmall.Checked = true;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            cbMeat.Items.Clear();
            for (int i = 0; i < Form1.NMeat.Count(); i++)
            {
                cbMeat.Items.Add(Form1.NMeat[i] + " - " + Form1.SMeat[i]);
            }
            chbPepper.Text = Form1.NTopping[0] + " - " + Form1.STopping[0];
            chbMushroom.Text = Form1.NTopping[1] + " - " + Form1.STopping[1];
            chbTomatoes.Text = Form1.NTopping[2] + " - " + Form1.STopping[2];
            chbPineapple.Text = Form1.NTopping[3] + " - " + Form1.STopping[3];
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                limitTopping = 1;
            }
            if (ctrTopping == limitTopping)
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        if (ch.Checked == false)
                        {
                            ch.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        ch.Enabled = true;
                    }
                }
                if(ctrTopping > limitTopping)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ch = (CheckBox)c;
                            ch.Enabled = true;
                            ch.Checked = false;
                        }
                    }
                }
            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                limitTopping = 2;
            }
            if (ctrTopping == limitTopping)
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        if (ch.Checked == false)
                        {
                            ch.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        ch.Enabled = true;
                    }
                }
                if (ctrTopping > limitTopping)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ch = (CheckBox)c;
                            ch.Enabled = true;
                            ch.Checked = false;
                        }
                    }
                }
            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                limitTopping = 3;
            }
            if (ctrTopping == limitTopping)
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        if (ch.Checked == false)
                        {
                            ch.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        ch.Enabled = true;
                    }
                }
                if (ctrTopping > limitTopping)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ch = (CheckBox)c;
                            ch.Enabled = true;
                            ch.Checked = false;
                        }
                    }
                }
            }
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Customer.openOrderPizza = false;
        }

        private void Order_Move(object sender, EventArgs e)
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

        private void chbPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPepper.Checked)
            {
                ctrTopping++;
            }
            else
            {
                ctrTopping--;
            }
            if(ctrTopping == limitTopping)
            {
                foreach(Control c in Controls)
                {
                    if(c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        if(ch.Checked == false)
                        {
                            ch.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        ch.Enabled = true;
                    }
                }
                if (ctrTopping > limitTopping)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ch = (CheckBox)c;
                            ch.Enabled = true;
                            ch.Checked = false;
                        }
                    }
                }
            }
        }

        private void chbMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMushroom.Checked)
            {
                ctrTopping++;
            }
            else
            {
                ctrTopping--;
            }
            if (ctrTopping == limitTopping)
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        if (ch.Checked == false)
                        {
                            ch.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        ch.Enabled = true;
                    }
                }
                if (ctrTopping > limitTopping)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ch = (CheckBox)c;
                            ch.Enabled = true;
                            ch.Checked = false;
                        }
                    }
                }
            }
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTomatoes.Checked)
            {
                ctrTopping++;
            }
            else
            {
                ctrTopping--;
            }
            if (ctrTopping == limitTopping)
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        if (ch.Checked == false)
                        {
                            ch.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        ch.Enabled = true;
                    }
                }
                if (ctrTopping > limitTopping)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ch = (CheckBox)c;
                            ch.Enabled = true;
                            ch.Checked = false;
                        }
                    }
                }
            }
        }

        private void chbPineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPineapple.Checked)
            {
                ctrTopping++;
            }
            else
            {
                ctrTopping--;
            }
            if (ctrTopping == limitTopping)
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        if (ch.Checked == false)
                        {
                            ch.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox ch = (CheckBox)c;
                        ch.Enabled = true;
                    }
                }
                if (ctrTopping > limitTopping)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox ch = (CheckBox)c;
                            ch.Enabled = true;
                            ch.Checked = false;
                        }
                    }
                }
            }
        }

        private void Order_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(Pizza != null)
            {
                g.DrawImage(Pizza, 275, 50, ukuranP, ukuranP);
            }
            if(Meat != null)
            {
                g.DrawImage(Meat, xMeat, yMeat, 50, 50);
            }
            if(Pepper != null)
            {
                g.DrawImage(Pepper, xPepper, yPepper, 50, 50);
            }
            if(Mushroom != null)
            {
                g.DrawImage(Mushroom, xMushroom, yMushroom, 50, 50);
            }
            if (Tomatoes != null)
            {
                g.DrawImage(Tomatoes, xTomatoes, yTomatoes, 50, 50);
            }
            if(Pineapple != null)
            {
                g.DrawImage(Pineapple, xPineapple, yPineapple, 50, 50);
            }
        }
    }
}