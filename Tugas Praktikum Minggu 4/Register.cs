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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string inpUsername = tbUsername.Text;
            string inpPassword = tbPassword.Text;
            string inpCPassword = tbCPassword.Text;
            bool ada = false;
            
            for (int i = 0; i < Form1.Customer.Count; i++)
            {
                if (inpUsername == Form1.Customer[i][0] && inpPassword == Form1.Customer[i][1])
                {
                    ada = true;
                }
            }
            if (ada)
            {
                MessageBox.Show("Akun Customer Sudah Ada");
            }
            else if (inpUsername == "Admin" && inpPassword == "Admin")
            {
                MessageBox.Show("Tidak Boleh Mendaftar Sebagai Akun Admin");
            }
            else
            {
                if(inpPassword == inpCPassword)
                {
                    string[] inpAkun = { inpUsername, inpPassword };
                    Form1.Customer.Add(inpAkun);

                    Form1.OKodeCustomer.Add(1);
                    Form1.OKCustomer.Add(new List<string>());
                    Form1.OHCustomer.Add(new List<int>());

                    Form1.OPCustomer.Add(new List<Image>());

                    Form1.OSCustomer.Add(new List<int>());

                    Form1.OMCustomer.Add(new List<Image>());
                    Form1.OXMCustomer.Add(new List<int>());
                    Form1.OYMCustomer.Add(new List<int>());

                    Form1.OPepperCustomer.Add(new List<Image>());
                    Form1.OXPepperCustomer.Add(new List<int>());
                    Form1.OYPepperCustomer.Add(new List<int>());

                    Form1.OMushroomCustomer.Add(new List<Image>());
                    Form1.OXMushroomCustomer.Add(new List<int>());
                    Form1.OYMushroomCustomer.Add(new List<int>());

                    Form1.OTomatoesCustomer.Add(new List<Image>());
                    Form1.OXTomatoesCustomer.Add(new List<int>());
                    Form1.OYTomatoesCustomer.Add(new List<int>());

                    Form1.OPineappleCustomer.Add(new List<Image>());
                    Form1.OXPineappleCustomer.Add(new List<int>());
                    Form1.OYPineappleCustomer.Add(new List<int>());

                    MessageBox.Show("Akun Customer " + inpUsername + " Terdaftar");
                }
                else
                {
                    MessageBox.Show("Confirm Password Salah");
                }
            }
        }
    }
}