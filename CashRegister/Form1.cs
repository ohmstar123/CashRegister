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

        double chipcost;
        double subcost;
        double cookiecost;

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
            //converting items to numbers
            chips = Convert.ToInt32(chipsInput.Text);
            footlong = Convert.ToInt32(subsInput.Text);
            cookies = Convert.ToInt32(cookiesInput.Text);

            //□ Get the number of burgers, fries, and drinks the user ordered and place them into the appropriate global variables.
            chipcost = chips * CHIPS;
            subcost = footlong * FOOTLONG;
            cookiecost = cookies * COOKIES;
            
            //□ Calculate the total before tax.Store in the appropriate global variable.
            totalcost = chipcost + subcost + cookiecost;
            subtotalOutput.Text = totalcost.ToString("C");
           
            //□ Calculate the tax amount. Store in the appropriate global variable.
            taxamount = TAX * totalcost;
            taxOutput.Text = taxamount.ToString("C");

            //Calculate the total including tax.Store in the appropriate global variable.
            totalwithtax = totalcost + taxamount;
            totalOutput.Text = totalwithtax.ToString("C");
        }

        private void calculatechangeButton_Click(object sender, EventArgs e)
        {
            //□ Get the amount tendered and place it into the appropriate global variable.
            tenderedamount = Convert.ToDouble(tenderedInput.Text);

            //Calculate the change(amount tendered – total including tax).Store in the appropriate global variable.
            changeamount = tenderedamount - totalwithtax;
            changeOutput.Text = changeamount.ToString("C");
        }

        private void printreceiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 2);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            g.DrawRectangle(drawPen, 350, 60, 200, 100);




        }
    }
}
