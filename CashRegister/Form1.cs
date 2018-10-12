using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// <summary>
/// Ohm Patel
/// October 12, 2018
/// Cash register at Subway
/// </summary>

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
            try
            {//converting items to numbers
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
            catch
            {
                tryLabel1.Text = "Please enter the amount of items you would like to buy";
                tryLabel1.Refresh();
                Thread.Sleep(2000);

                tryLabel1.Text = "";
            }
        }

        private void calculatechangeButton_Click(object sender, EventArgs e)
        {
            try
            {//□ Get the amount tendered and place it into the appropriate global variable.
                tenderedamount = Convert.ToDouble(tenderedInput.Text);

                //Calculate the change(amount tendered – total including tax).Store in the appropriate global variable.
                changeamount = tenderedamount - totalwithtax;
                changeOutput.Text = changeamount.ToString("C");
            }
            catch
            {
                tryLabel2.Text = "Please enter the amount of money you would like to give";
                tryLabel2.Refresh();
                Thread.Sleep(2000);

                tryLabel2.Text = "";
            }
            
        }

        private void printreceiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 2);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //square outline
            g.DrawRectangle(drawPen, 350, 60, 400, 375);
            g.FillRectangle(drawBrush, 350, 60, 400, 375);

            //writing
            Font writingFont = new Font("Consolas", 15, FontStyle.Bold);
            SolidBrush writingBrush = new SolidBrush(Color.Black);

            SoundPlayer player = new SoundPlayer(Properties.Resources._345053__azumarill__epson_receipt_printer6);
            player.Play();

            Thread.Sleep(833);
            g.DrawString("Subway", writingFont, writingBrush, 510, 80);

            writingFont = new Font("Consolas", 10, FontStyle.Bold);
            Thread.Sleep(833);
            g.DrawString("Order Number 9999", writingFont, writingBrush, 375, 120);
            Thread.Sleep(833);
            g.DrawString("October 15, 2018", writingFont, writingBrush, 375, 140);

            Thread.Sleep(833);
            g.DrawString("Footlong subs   x" + subsInput.Text + " @ " + subcost.ToString("C"), writingFont, writingBrush, 375, 180);
            Thread.Sleep(833);
            g.DrawString("Chips           x" + chipsInput.Text + " @ " + chipcost.ToString("C"), writingFont, writingBrush, 375, 200);
            Thread.Sleep(833);
            g.DrawString("Cookies         x" + cookiesInput.Text + " @ " + cookiecost.ToString("C"), writingFont, writingBrush, 375, 220);

             player = new SoundPlayer(Properties.Resources._345053__azumarill__epson_receipt_printer6);
            player.Play();

            Thread.Sleep(833);
            g.DrawString("Subtotal             " + totalcost.ToString("C"), writingFont, writingBrush, 375, 260);
            Thread.Sleep(833);
            g.DrawString("Tax                  " + taxamount.ToString("C"), writingFont, writingBrush, 375, 280);
            Thread.Sleep(833);
            g.DrawString("Total                " + totalwithtax.ToString("C"), writingFont, writingBrush, 375, 300);

            Thread.Sleep(833);
            g.DrawString("Tendered             " + tenderedamount.ToString("C"), writingFont, writingBrush, 375, 340);
            Thread.Sleep(833);
            g.DrawString("Change               " + changeamount.ToString("C"), writingFont, writingBrush, 375, 360);

            Thread.Sleep(833);
            g.DrawString("Thank You, Come Again", writingFont, writingBrush, 375, 400);

            neworderButton.Visible = true;




        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.GreenYellow);

            neworderButton.Visible = false;

            //input reset
            subsInput.Text = "";
            chipsInput.Text = "";
            cookiesInput.Text = "";
            tenderedInput.Text = "";

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";

            //varible reset
            chips = 0;
            footlong = 0;
            cookies = 0;

            chipcost = 0;
            subcost = 0;
            cookiecost = 0;

            totalcost = 0;
            taxamount = 0;
            totalwithtax = 0;
            tenderedamount = 0;
            changeamount = 0;

            tryLabel1.Text = "";
            tryLabel2.Text = "";




        }
    }
}
