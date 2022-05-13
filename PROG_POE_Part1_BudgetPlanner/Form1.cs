using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_POE_Part1_BudgetPlanner
{
    public partial class frmBudgetPlanner : Form
    {
        public frmBudgetPlanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setting limits on months allowed to be chosen
            nudRepay.Minimum = 240;
            nudRepay.Maximum = 360;
        }
        private void cmbChooseHousing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChooseHousing.Text == "Renting.")
            {
                lblRentAmount.Visible = true;
                nudRentAmount.Visible = true;
                lblPurchasePrice.Visible = false;
                nudPurchasePrice.Visible = false;
                lblDeposit.Visible = false;
                nudDeposit.Visible = false;
                lblInterest.Visible = false;
                nudInterest.Visible = false;
                lblRepay.Visible = false;
                nudRepay.Visible = false;
            }
            else
            {
                if (cmbChooseHousing.Text == "Buying a property.")
                {
                    lblRentAmount.Visible = false;
                    nudRentAmount.Visible = false;
                    lblPurchasePrice.Visible = true;
                    nudPurchasePrice.Visible = true;
                    lblDeposit.Visible = true;
                    nudDeposit.Visible = true;
                    lblInterest.Visible = true;
                    nudInterest.Visible = true;
                    lblRepay.Visible = true;
                    nudRepay.Visible = true;
                }
            }
        }
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {


            //Creating an instance of the MortgageLoan class
            MortgageLoan mL = new MortgageLoan();

            //declare variables
            int grossIncome = decimal.ToInt32(nudMonthlyIncome.Value);
            int groceries = decimal.ToInt32(nudGroceries.Value);
            int water = decimal.ToInt32(nudWaterLights.Value);
            int travel = decimal.ToInt32(nudTravel.Value);
            int phone = decimal.ToInt32(nudPhone.Value);
            int other = decimal.ToInt32(nudOtherEx.Value);
            int tax = decimal.ToInt32(nudTax.Value);
            int rent = decimal.ToInt32(nudRentAmount.Value);
            int purchasePrice = decimal.ToInt32(nudPurchasePrice.Value);
            int totaldeposit = decimal.ToInt32(nudDeposit.Value);
            int interest = decimal.ToInt32(nudInterest.Value);
            int repay = decimal.ToInt32(nudRepay.Value);
            int RepaymentValue =0;
            int monthlyRepaymentValue = 0;
            int monthlyAvailableMoney=0;

            /*Referencing:
              * Date:  30 Jan, 2019
              * Website Name:Decimal.ToInt32() Method in C#, GeeksforGeeks
              * URL: https://www.geeksforgeeks.org/decimal-toint32-method-in-c-sharp/ 
              */

            //declaing and populating expense array
            int[] arrExpenses = new int[7]
                {groceries, water,travel,phone,other,tax,totaldeposit};

            /*Referencing:
             * Date: 23 Feb 2020
             * Website Name:Populating an array by ScriptingMaster
             * URL:http://www.scriptingmaster.com/javascript/populating-array.asp#:~:text=To%20populate%20an%20array%20with,URLsArray%20%3D%20new%20Array%20(4)%3B
             */

            //calculating sum of expense array
            int sum = 0;
            for (int i = 0; i < arrExpenses.Length; i++)
            {
                sum = arrExpenses[i];
            }

            /*Referencing:
             * Date:31 Oct 2018
             * Website Name:How to sum up an array of integers in C# by Stack Overflow
             * URL: https://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
             */

            //Calculates the  home loan repayment
            RepaymentValue = mL.RepaymentFull(totaldeposit, purchasePrice, interest, repay);
            //Calculates the monthly home loan repayment
            monthlyRepaymentValue = mL.MonthlyRepayment(totaldeposit, purchasePrice, interest, repay);

            


            if (cmbChooseHousing.Text == "Renting.")
            {
                //Calculates the monthly available money
                monthlyAvailableMoney = grossIncome - (sum);

                redDisplay.Text = "Your monthly gross income is: R" + Convert.ToString(grossIncome)+
                    "\nYou have chosen to rent a living space. Your monthly rent will be: R"+
                    Convert.ToString(rent)+
                    //Displays total expenses
                            "\nYour total expenses for the month excluding the rent expense is: R" +
                            Convert.ToString(sum) +
                            "\nYour total expenses for the month incuding the rent expense is: R" +
                            Convert.ToString(sum+rent) +
                            "\nAvailable amount before deducting the rent expense is: R" +
                            Convert.ToString(monthlyAvailableMoney) +
                            "\nAvailable amount after deducting the rent expense is: R" +
                            Convert.ToString(monthlyAvailableMoney-rent) 
                    ;
            }
            else
            {
                if (cmbChooseHousing.Text == "Buying a Property.")
                {
                    if ((nudRepay.Value > 360) || (nudRepay.Value < 240))
                    {
                        MessageBox.Show("Repayment months entered is invalid.");

                    }

                    //Calculates the monthly available money
                    monthlyAvailableMoney = grossIncome - (sum);

                    //calculate a third of this months income
                    int third = grossIncome * 1 / 3;
                    
                    //alert user that home loan may not be approved 
                    if (monthlyRepaymentValue > third)
                    {
                        MessageBox.Show("Sorry, approval of the home loan looks unlikely.");
                    }
                    else
                    {
                        //Display summary of information
                        redDisplay.Text = "Your monthly gross income is: R"+ Convert.ToString(grossIncome)+
                            "\nYou have chosen to buy a property. Your monthly home loan repayment amount is: R"+
                            Convert.ToString(monthlyRepaymentValue)+" and is likely to be approved."+

                            //Displays total expenses
                            "\nYour total expenses for the month excluding the home loan repayment is: R"+
                            Convert.ToString(sum)+
                            "\nYour total expenses for the month including the home loan repayment is: R" +
                            Convert.ToString(sum+monthlyRepaymentValue) +

                            //Calculates amount available 
                            "\nAvailable amount before deducting the home repayment is: R" + 
                            Convert.ToString(monthlyAvailableMoney)+
                            "\nAvailable amount after deducting the home repayment is: R" +
                            Convert.ToString(monthlyAvailableMoney-monthlyRepaymentValue)
                            ;
                    }


                }
              

            }

            /*Referencing:
             * Date:NA
             * Website Name:How to Convert int to String with Sample Code - C# ... by eduCBA
             * URL:https://www.educba.com/convert-int-to-string-c-sharp/
             */
        }


    }
}
