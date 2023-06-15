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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int idxCustomer = -1;
        public static int loginCustomer;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inpUsername = tbUsername.Text;
            string inpPassword = tbPassword.Text;
            if(inpUsername == "Admin" && inpPassword == "Admin")
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                idxCustomer = -1;
                for(int i = 0; i < Form1.Customer.Count; i++)
                {
                    if (inpUsername == Form1.Customer[i][0] && inpPassword == Form1.Customer[i][1])
                    {
                        idxCustomer = i;
                    }
                }
                if(idxCustomer != -1)
                {
                    Customer customer = new Customer();
                    customer.Show();
                    customer.lblJudul.Text = "Welcome, " + Form1.Customer[idxCustomer][0].ToString();
                    loginCustomer = idxCustomer;
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                }
            }
        }
    }
}