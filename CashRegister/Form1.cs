using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
   
    public partial class Form1 : Form
    {
        //variables
        int chips;
        int footlong;
        int cookies;
        double totalcost;
        double taxamount;
        double totalwithtax;
        double tenderedamount;
        double changeamount;



        //prices
        const double FOOTLONG = 5.00;
        const double CHIPS = 1.10;
        const double COOKIES = 0.65;
        const double TAX = 0.13;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculatetotalButton_Click(object sender, EventArgs e)
        {
            chips = Convert.ToInt32
        }
    }
}
