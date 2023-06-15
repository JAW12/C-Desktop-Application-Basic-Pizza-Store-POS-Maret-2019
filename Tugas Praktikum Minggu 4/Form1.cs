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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<string[]> Customer = new List<string[]>();
        public static List<int> OKodeCustomer = new List<int>();
        public static List<List<string>> OKCustomer = new List<List<string>>();
        public static List<List<int>> OHCustomer = new List<List<int>>();

        public static List<List<Image>> OPCustomer = new List<List<Image>>();

        public static List<List<int>> OSCustomer = new List<List<int>>();

        public static List<List<Image>> OMCustomer = new List<List<Image>>();
        public static List<List<int>> OXMCustomer = new List<List<int>>();
        public static List<List<int>> OYMCustomer = new List<List<int>>();

        public static List<List<Image>> OPepperCustomer = new List<List<Image>>();
        public static List<List<int>> OXPepperCustomer = new List<List<int>>();
        public static List<List<int>> OYPepperCustomer = new List<List<int>>();

        public static List<List<Image>> OMushroomCustomer = new List<List<Image>>();
        public static List<List<int>> OXMushroomCustomer = new List<List<int>>();
        public static List<List<int>> OYMushroomCustomer = new List<List<int>>();

        public static List<List<Image>> OTomatoesCustomer = new List<List<Image>>();
        public static List<List<int>> OXTomatoesCustomer = new List<List<int>>();
        public static List<List<int>> OYTomatoesCustomer = new List<List<int>>();

        public static List<List<Image>> OPineappleCustomer = new List<List<Image>>();
        public static List<List<int>> OXPineappleCustomer = new List<List<int>>();
        public static List<List<int>> OYPineappleCustomer = new List<List<int>>();

        public static string[] NPizza;
        public static string[] NMeat;
        public static string[] NTopping;

        public static int[] HPizza;
        public static int[] HMeat;
        public static int[] HTopping;

        public static int[] SPizza;
        public static int[] SMeat;
        public static int[] STopping;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NPizza = new string[2];
            NPizza[0] = "Plain Pizza";
            NPizza[1] = "Black Pizza";

            HPizza = new int[2];
            HPizza[0] = 30000;
            HPizza[1] = 40000;

            SPizza = new int[2];
            SPizza[0] = 10;
            SPizza[1] = 10;


            NMeat = new string[3];
            NMeat[0] = "Beef";
            NMeat[1] = "Chicken";
            NMeat[2] = "Shrimp";

            HMeat = new int[3];
            HMeat[0] = 25000;
            HMeat[1] = 15000;
            HMeat[2] = 20000;

            SMeat = new int[3];
            SMeat[0] = 10;
            SMeat[1] = 10;
            SMeat[2] = 10;

            NTopping = new string[4];
            NTopping[0] = "Pepper";
            NTopping[1] = "Mushroom";
            NTopping[2] = "Tomatoes";
            NTopping[3] = "Pineapple";

            HTopping = new int[4];
            HTopping[0] = 5000;
            HTopping[1] = 7500;
            HTopping[2] = 12500;
            HTopping[3] = 10000;

            STopping = new int[4];
            STopping[0] = 10;
            STopping[1] = 10;
            STopping[2] = 10;
            STopping[3] = 10;
        }
    }
}
