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
    public partial class Lihat_Stock : Form
    {
        public Lihat_Stock()
        {
            InitializeComponent();
        }
        Brush[] brush;
        String[] warnab = { "Pink", "Blue", "Orange", "Lime" };
        int yR = 500;
        int[] Stock;
        int StockMax;
        int xK;
        bool Hover = false;
        int kategori = -1;
        string judul = "Keterangan";
        string swarna = "Warna \t: ";
        string snama = "Nama \t: ";
        string sjumlah = "Jumlah \t: ";
        string warna = "";
        string nama = "";
        string jumlah = "";
        private void Lihat_Stock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Black, 2);
            Pen pr = new Pen(Brushes.Black);
            Font f = new Font("Arial", 14, FontStyle.Regular);
            Font fb = new Font("Arial", 14, FontStyle.Bold);
            if (Stock != null)
            {
                for (int i = 0; i < Stock.Count(); i++)
                {
                    g.FillRectangle(brush[i], 25 + (40 * i), yR - (int)(1.0 * Stock[i] / StockMax * 300), 40, (int)(1.0 * Stock[i] / StockMax * 300));
                }
                for(int i = 1; i < Stock.Count(); i++)
                {
                    g.DrawLine(p, 5 + (40 * i), yR - (int)(1.0 * Stock[i - 1] / StockMax * 300), 5 + (40 * (i + 1)), yR - (int)(1.0 * Stock[i] / StockMax * 300));
                }
                if (Hover && jumlah != "0")
                {
                    g.DrawRectangle(pr, xK, 250, 250, 150);
                    g.DrawString(judul, f, Brushes.Black, xK + 5, 255);
                    g.DrawString(swarna, fb, Brushes.Black, xK + 5, 300);
                    g.DrawString(snama, fb, Brushes.Black, xK + 5, 325);
                    g.DrawString(sjumlah, fb, Brushes.Black, xK + 5, 350);
                    g.DrawString(warna, f, Brushes.Black, xK + 125, 300);
                    g.DrawString(nama, f, Brushes.Black, xK + 125, 325);
                    g.DrawString(jumlah, f, Brushes.Black, xK + 125, 350);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(cbKategori.SelectedIndex == 0)
            {
                kategori = 0;
                Stock = new int[2];
                Stock[0] = Form1.SPizza[0];
                Stock[1] = Form1.SPizza[1];
                StockMax = -1;
                for(int i =0;i < Stock.Count(); i++)
                {
                    if(Stock[i] >= StockMax)
                    {
                        StockMax = Stock[i];
                    }
                }
                xK = 2 * 80;
            }
            else if(cbKategori.SelectedIndex == 1)
            {
                kategori = 1;
                Stock = new int[3];
                Stock[0] = Form1.SMeat[0];
                Stock[1] = Form1.SMeat[1];
                Stock[2] = Form1.SMeat[2];
                StockMax = -1;
                for (int i = 0; i < Stock.Count(); i++)
                {
                    if (Stock[i] >= StockMax)
                    {
                        StockMax = Stock[i];
                    }
                }
                xK = 3 * 80;
            }
            else if(cbKategori.SelectedIndex == 2)
            {
                kategori = 2;
                Stock = new int[4];
                Stock[0] = Form1.STopping[0];
                Stock[1] = Form1.STopping[1];
                Stock[2] = Form1.STopping[2];
                Stock[3] = Form1.STopping[3];
                StockMax = -1;
                for (int i = 0; i < Stock.Count(); i++)
                {
                    if (Stock[i] >= StockMax)
                    {
                        StockMax = Stock[i];
                    }
                }
                xK = 4 * 80;
            }
            this.Refresh();
        }

        private void Lihat_Stock_Load(object sender, EventArgs e)
        {
            brush = new Brush[4];
            brush[0] = Brushes.Pink;
            brush[1] = Brushes.Blue;
            brush[2] = Brushes.Orange;
            brush[3] = Brushes.Lime;
        }

        private void Lihat_Stock_MouseMove(object sender, MouseEventArgs e)
        {
            bool adaHover = false;
            if (kategori == 0)
            {
                if (Stock != null && Stock.Count() == Form1.NPizza.Count())
                {
                    for (int i = 0; i < Stock.Count(); i++)
                    {
                        if (e.Location.X >= 25 + (40 * i) && e.Location.Y >= yR - (int)(1.0 * Stock[i]  / StockMax * 300) && e.Location.X <= 65 + (40 * i) && e.Location.Y <= yR)
                        {
                            adaHover = true;
                            warna = warnab[i];
                            nama = Form1.NPizza[i];
                            jumlah = Form1.SPizza[i].ToString();
                        }
                    }
                }
            }
            else if (kategori == 1)
            {
                if (Stock != null && Stock.Count() == Form1.NMeat.Count())
                {
                    for (int i = 0; i < Stock.Count(); i++)
                    {
                        if (e.Location.X >= 25 + (40 * i) && e.Location.Y >= yR - (int)(1.0 * Stock[i] / StockMax * 300) && e.Location.X <= 65 + (40 * i) && e.Location.Y <= yR)
                        {
                            adaHover = true;
                            warna = warnab[i];
                            nama = Form1.NMeat[i];
                            jumlah = Form1.SMeat[i].ToString();
                        }
                    }
                }
            }
            else if (kategori == 2)
            {
                if (Stock != null && Stock.Count() == Form1.NTopping.Count())
                {
                    for (int i = 0; i < Stock.Count(); i++)
                    {
                        if (e.Location.X >= 25 + (40 * i) && e.Location.Y >= yR - (int)(1.0 * Stock[i] / StockMax * 300) && e.Location.X <= 65 + (40 * i) && e.Location.Y <= yR)
                        {
                            adaHover = true;
                            warna = warnab[i];
                            nama = Form1.NTopping[i];
                            jumlah = Form1.STopping[i].ToString();
                        }
                    }
                }
            }
            if (adaHover)
            {
                Hover = true;
            }
            else
            {
                Hover = false;
            }
            this.Invalidate();
        }

        private void Lihat_Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin.openLihatStock = false;
        }

        private void Lihat_Stock_Move(object sender, EventArgs e)
        {
            Form ff = this.MdiParent;
            Admin admin = (Admin)ff;

            if (this.Location.X >= -800 && this.Location.X <= 185 && this.Location.Y >= -700 && this.Location.Y <= 35)
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